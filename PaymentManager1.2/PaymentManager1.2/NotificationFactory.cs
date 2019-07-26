using System;

namespace PaymentManager1._2
{
    public class NotificationFactory
    {
        public INotificationManager GetNotificationType(string notificationType)
        {
            switch (notificationType.ToLowerInvariant())
            {
                case "sms":
                    return new SMSNotification();
                case "email":
                    return new EmailNotification();
                default:
                    throw new NotSupportedException();
            }
        }
    }

}
