using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RentOpsObjects.Model;

namespace RentOpsWebApp.Services
{
    public class NotificationService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public NotificationService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<RentOpsDBContext>();
                    var notificationLogic = new NotificationLogic(context);
                    notificationLogic.SendReturnReminderNotifications();
                }

                // Wait for 1 hour before the next update (adjust as needed)
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }
        }
    }
}
