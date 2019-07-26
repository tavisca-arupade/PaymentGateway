using System;
using System.Linq;
using Xunit;
using PaymentManager1._2;

namespace PaymentManagerTestProject
{
    public class PaymentMethodTestClass
    {
        [Fact]
        public void TestPaymentFactoryForCardPayment()
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            IPayment actualObject = paymentFactory.GetPaymentMethod("card");

            Assert.IsType<CardPayment>(actualObject);
        }

        [Fact]
        public void TestPaymentFactoryForPayTmPayment()
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            IPayment actualObject = paymentFactory.GetPaymentMethod("PayTm");

            Assert.IsType<PayTmPayment>(actualObject);
        }

        [Fact]
        public void TestPaymentFactoryForPaymentStatusOfPayTmPayment()
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            IPayment payment = paymentFactory.GetPaymentMethod("PayTm");

            payment.SendDetails("ABC", "XY345");
            Assert.Equal(true, payment.DoPayment());
        }

        [Fact]
        public void TestPaymentFactoryForPaymentStatusOfCardPayment()
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            IPayment payment = paymentFactory.GetPaymentMethod("card");

            payment.SendDetails("ABC", "XY345");
            Assert.Equal(true, payment.DoPayment());
        }
    }
}
