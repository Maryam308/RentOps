using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RentOpsObjects.Model;

namespace RentOpsObjects.Services
{
    public class AuditLogger
    {
        private readonly RentOpsDBContext _context;

        public AuditLogger(RentOpsDBContext context)
        {
            _context = context;
        }

        public void TrackChanges(int userId, int sourceId, int logTypeId)
        {
            var entries = _context.ChangeTracker
                                  .Entries()
                                  .Where(e => e.State == EntityState.Modified)
                                  .ToList();

            foreach (var entry in entries)
            {
                var previousValues = new Dictionary<string, object?>();
                var currentValues = new Dictionary<string, object?>();

                foreach (var property in entry.OriginalValues.Properties)
                {
                    var original = entry.OriginalValues[property];
                    var current = entry.CurrentValues[property];

                    if (!Equals(original, current))
                    {
                        previousValues[property.Name] = original;
                        currentValues[property.Name] = current;
                    }
                }

                if (previousValues.Count > 0)
                {
                    var log = new Log
                    {
                        UserId = userId,
                        SourceId = sourceId,
                        LogTypeId = logTypeId,
                        LogTimestamp = DateTime.UtcNow,
                        AffectedData = entry.Metadata.Name,
                        PreviousValue = JsonConvert.SerializeObject(previousValues),
                        CurrentValue = JsonConvert.SerializeObject(currentValues),
                        UserAction = "Update"
                    };

                    _context.Logs.Add(log);
                }
            }
        }

    }
}
