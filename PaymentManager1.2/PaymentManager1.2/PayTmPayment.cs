namespace PaymentManager1._2
{
    public class PayTmPayment : IPayment
    {
        static NotificationFactory _notificationFactory = new NotificationFactory();
        INotificationManager _notificationManager = _notificationFactory.GetNotificationType("sms");
        private UserData _userData = new UserData();
        public bool DoPayment()
        {
            return _notificationManager.NotifyPayment();
        }

        public bool PaymentStatus()
        {
            return _notificationManager.NotifyStatus();
        }

        public void SendDetails(string userName, string accountNumber)
        {
            _userData._userName = userName;
            _userData._cardNumber = accountNumber;
        }
    }
}

