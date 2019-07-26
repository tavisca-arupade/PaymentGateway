using System;
using Xunit;
using PaymentManager1._2;

namespace PaymentManagerTestProject
{
    public class PaymentManagerTestClass
    {
               
          [Fact]
        public void TestPaymentManagerForPaymentStatusOfCardPayment()
        {
            PaymentManager paymentManager = new PaymentManager();
            paymentManager.SelectPaymentMode("card");

            paymentManager.SendUserDetails("ABC", "XY345");
            Assert.Equal(true, paymentManager.VerifyUser());
        }
        [Fact]
        public void TestPaymentManagerForPaymentStatusOfPayTmPayment()
        {
            PaymentManager paymentManager = new PaymentManager();
            paymentManager.SelectPaymentMode("PayTm");

            paymentManager.SendUserDetails("ABC", "XY345");
            Assert.Equal(true, paymentManager.VerifyUser());
        }
    }
}
