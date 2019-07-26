using System;
using System.Linq;
using Xunit;
using PaymentManager1._2;

namespace PaymentManagerTestProject
{
    public class NotificationManagerTest
    {
        [Fact]
        public void TestNotificationFactoryForSMSNotification()
        {
            NotificationFactory notificationFactory = new NotificationFactory();
            INotificationManager actualObject = notificationFactory.GetNotificationType("SMS");

            Assert.IsType<SMSNotification>(actualObject);
        }

        [Fact]
        public void TestNotificationFactoryForEmailNotification()
        {
            NotificationFactory notificationFactory = new NotificationFactory();
            INotificationManager actualObject = notificationFactory.GetNotificationType("Email");

            Assert.IsType<EmailNotification>(actualObject);
        }
    }
}
