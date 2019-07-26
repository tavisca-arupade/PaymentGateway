namespace PaymentManager1._2

{
    public class PaymentManager
    {
        static PaymentFactory _paymentFactory = new PaymentFactory();
        static VerificationFactory _verificationFactory = new VerificationFactory();
        IPayment _payment;
        IVerification _verification = _verificationFactory.GetVerificationType("sms");
        public void SelectPaymentMode(string paymentMode)
        {
            _payment = _paymentFactory.GetPaymentMethod(paymentMode);
        }

        public void SendUserDetails(string userName, string accountNumber)
        {
            _payment.SendDetails(userName, accountNumber);
        }

        public bool VerifyUser()
        {
            if (_verification.VerifyUser())
               return MakePayment();
            return false;
        }

        internal bool MakePayment()
        {
            if (_payment.DoPayment())
                return _payment.PaymentStatus();
            return false;
        }
    }
}
