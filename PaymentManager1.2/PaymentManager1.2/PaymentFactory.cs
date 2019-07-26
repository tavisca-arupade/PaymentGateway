using System;

namespace PaymentManager1._2
{
    public class PaymentFactory
    {
        public IPayment GetPaymentMethod(string paymentMethod)
        {
            switch (paymentMethod.ToLowerInvariant())
            {
                case "card":
                    return new CardPayment();
                case "paytm":
                    return new PayTmPayment();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
