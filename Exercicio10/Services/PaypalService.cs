namespace Exercicio10.Services
{
    internal class PaypalService : IPaymentProvider
    {
        public double InterestRate(double amount)
        {
            return amount *0.01;
        }
        public double PaymentFee(double amount)
        {
            return amount *0.02;
        }
    }
}
