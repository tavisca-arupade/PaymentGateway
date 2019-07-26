namespace PaymentManager1._2
{
    public class SMSNotification : INotificationManager
    {
        
        private string _notificationMessage;

        public bool NotifyStatus()
        {
            _notificationMessage = "Payment Completed";
            return true;
        }

        public bool NotifyPayment()
        {
            _notificationMessage = "Payment Reciept";
            return true;
        }
    }

}
