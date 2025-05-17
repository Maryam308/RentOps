using RentOpsObjects.Model;
using System;
using System.Linq;

namespace RentOpsWebApp.Services
{
    public class NotificationLogic
    {
        private readonly RentOpsDBContext _context;

        public NotificationLogic(RentOpsDBContext context)
        {
            _context = context;
        }

        public void SendReturnReminderNotifications()
        {
            var tomorrow = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
            var threeDaysFromNow = DateOnly.FromDateTime(DateTime.Now.AddDays(3));

            var dueRentalsTomorrow = _context.RentalRequests
                .Where(r => r.RentalReturnDate == tomorrow && r.RentalRequestStatusId == 2)
                .ToList();

            var dueRentalsThreeDays = _context.RentalRequests
                .Where(r => r.RentalReturnDate == threeDaysFromNow && r.RentalRequestStatusId == 2)
                .ToList();

            var reminderMessageTomorrow = _context.MessageContents
                .FirstOrDefault(m => m.MessageContentText == "Reminder: Your rented equipment is due for return tomorrow.");

            var reminderMessageThreeDays = _context.MessageContents
                .FirstOrDefault(m => m.MessageContentText == "Important: Please return your rental by the scheduled date.");

            foreach (var rental in dueRentalsTomorrow)
            {
                if (reminderMessageTomorrow != null )
                {
                    var notification = new Notification
                    {
                        UserId = rental.UserId,
                        MessageContentId = reminderMessageTomorrow.MessageContentId,
                        NotificationStatusId = 1,
                        NotificationTimestamp = DateTime.Now
                    };

                    _context.Notifications.Add(notification);
                }
            }

            foreach (var rental in dueRentalsThreeDays)
            {
                if (reminderMessageThreeDays != null )
                {
                    var notification = new Notification
                    {
                        UserId = rental.UserId,
                        MessageContentId = reminderMessageThreeDays.MessageContentId,
                        NotificationStatusId = 1,
                        NotificationTimestamp = DateTime.Now
                    };

                    _context.Notifications.Add(notification);
                }
            }

            _context.SaveChanges();
        }
    }

}
