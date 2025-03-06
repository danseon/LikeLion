namespace InterfaceExam2
{
    interface IPayment
    {
        void ProcessPayment();
    }

    //신용카드 결제 클래스
    class CreditCardPayment : IPayment{
        public void ProcessPayment()
        {
            Console.WriteLine("신용카드 결제 완료!");
        }
    }

    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("페이팔 결제 완료!");
        }
    }
    //결제처리기
    class PaymentProcessor
    {
        public void Pay(IPayment payment)
        {
            payment.ProcessPayment();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();

            IPayment creditCard = new CreditCardPayment();
            IPayment paypal = new PayPalPayment();

            processor.Pay(creditCard);
            processor.Pay(paypal);
        }
    }
}