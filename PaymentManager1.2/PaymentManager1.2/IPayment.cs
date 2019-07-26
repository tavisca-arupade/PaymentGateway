namespace PaymentManager1._2
{
    public interface IPayment
    {
        void SendDetails(string userName, string accountNumber);
        bool DoPayment();
        bool PaymentStatus();
    }
}

