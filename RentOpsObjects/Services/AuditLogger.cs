using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RentOpsObjects.Model;

namespace RentOpsObjects.Services
{
    //this is a class that will be utilized to log changes to the database including adds, updates, and deletes
    public class AuditLogger
    {
        private  RentOpsDBContext _context;

        public AuditLogger(RentOpsDBContext context)
        {
            _context = context;
        }

        //The TrackChanges method will be called before the SaveChanges method of the DbContext
        public void TrackChanges(int? userId, int sourceId)
        {
            //print an indication that the track changes method was called
            Console.WriteLine("TrackChanges method called");

            // Get all entries that are being added, modified, or deleted
            var entries = _context.ChangeTracker.Entries()
                                  .Where(e => e.State == EntityState.Modified ||
                                              e.State == EntityState.Added ||
                                              e.State == EntityState.Deleted)
                                  .ToList();

            //print an indication that the entries were found
            Console.WriteLine($"Found {entries.Count} entries to log");

            // Loop through each entry and log the changes
            foreach (var entry in entries)
            {
                //Declare dictionaries to hold the previous and current values
                var previousValues = new Dictionary<string, object?>();
                var currentValues = new Dictionary<string, object?>();

                // Loop through the properties of the entity and get the original and current values
                foreach (var property in entry.OriginalValues.Properties)
                {
                    //Get the original and current values of the property
                    var original = entry.OriginalValues[property];
                    var current = entry.CurrentValues[property];

                    // Check if the property value has changed
                    if (entry.State == EntityState.Modified && !Equals(original, current))
                    {
                        previousValues[property.Name] = original;
                        currentValues[property.Name] = current;
                    }
                }

                // If the entry is being added or deleted, we need to get the current or original values respectively
                // For added entries, we take the current values
                if (entry.State == EntityState.Added)
                {
                    // Loop through the properties of the entity and get the current values
                    foreach (var property in entry.CurrentValues.Properties)
                    {
                        currentValues[property.Name] = entry.CurrentValues[property];
                    }
                }

                // For deleted entries, we take the original values
                if (entry.State == EntityState.Deleted)
                {
                    // Loop through the properties of the entity and get the original values
                    foreach (var property in entry.OriginalValues.Properties)
                    {
                        previousValues[property.Name] = entry.OriginalValues[property];
                    }
                }

                // Create a new log entry
                var log = new Log
                {
                    UserId = userId,
                    SourceId = sourceId,
                    LogTypeId = 1,
                    LogTimestamp = DateTime.UtcNow,
                    AffectedData = entry.Metadata.Name,
                    PreviousValue = previousValues.Count > 0 ? JsonConvert.SerializeObject(previousValues) : "",
                    CurrentValue = currentValues.Count > 0 ? JsonConvert.SerializeObject(currentValues) : "",
                    UserAction = entry.State.ToString(), // "Added", "Modified", or "Deleted"
                    Exception = null // No exception for normal operations
                };

                // Add the log entry to the context, but don't save it yet cause we want to save all changes at once after the track changes is called always save changes is called
                _context.Logs.Add(log);
                // Save the changes to the database
                 _context.SaveChanges(); // Uncomment this if you want to save immediately after each log entry
            }


        }

        // This method will be called to log exceptions
        public void LogException(int? userId, string errorMessage, string stackTrace, int sourceId)
        {
            try 
            {
                // Create a new log entry for the exception
                var log = new Log
                {
                    UserId = userId,
                    SourceId = sourceId,
                    LogTypeId = 2, // Special log type for exceptions
                    LogTimestamp = DateTime.UtcNow,
                    AffectedData = "System Error",
                    PreviousValue = "",
                    CurrentValue = JsonConvert.SerializeObject(new { errorMessage, stackTrace }),
                    UserAction = "",
                    Exception = errorMessage


                };

                // Add the log entry to the context
                _context.Logs.Add(log);
                _context.SaveChanges(); // Save the error log immediately because we want to ensure we capture the error and save changes wont be called where the logexception is called
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur while creating the log entry
                Console.WriteLine($"Error while logging exception: {ex.Message}");
            }

         
        }

        // This method will be called to log login activity
        public void LogLoginActivity(int? userId, int sourceId, string userAction, string? previousEmail = null, string? previousPassword = null, string? currentEmail = null, string? currentPassword = null)
        {
            try 
            {
                //the affected data will be the user id if it is not null
                string affectedData = userId.HasValue
            ? $"AspNetUsers: ID = {userId.Value}"
            : "AspNetUsers: Unknown or Failed Login Attempt";

                // declare previous and current JSON value holders
                string previousValue = "";
                string currentValue = "";

                // log previous input (if available) - this is used in case of multiple failed login attempts
                if (!string.IsNullOrEmpty(previousEmail) || !string.IsNullOrEmpty(previousPassword))
                {
                    var previousValues = new Dictionary<string, object?>
        {
            { "Email", previousEmail },
            { "Password", previousPassword }
        };

                    previousValue = JsonConvert.SerializeObject(previousValues, Formatting.Indented);
                }

                // log current input (if available)
                if (!string.IsNullOrEmpty(currentEmail) || !string.IsNullOrEmpty(currentPassword))
                {
                    var currentValues = new Dictionary<string, object?>
        {
            { "Email", currentEmail },
            { "Password", currentPassword }
        };

                    currentValue = JsonConvert.SerializeObject(currentValues, Formatting.Indented);
                }

                var log = new Log
                {
                    UserId = userId,
                    SourceId = sourceId, // web app or desktop app
                    LogTypeId = 1, // Action Log 
                    LogTimestamp = DateTime.UtcNow,
                    AffectedData = affectedData,
                    PreviousValue = previousValue,
                    CurrentValue = currentValue,
                    UserAction = userAction,
                    Exception = null
                };

                _context.Logs.Add(log);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur while creating the log entry
                Console.WriteLine($"Error while logging login activity: {ex.Message}");
            }
        }





    }

}

