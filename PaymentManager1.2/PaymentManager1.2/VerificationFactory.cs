using System;

namespace PaymentManager1._2

{
    public class VerificationFactory
    {
        public IVerification GetVerificationType(string verificationType)
        {
            switch (verificationType)
            {
                case "sms":
                    return new SMSVerificationManager();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
