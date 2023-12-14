namespace Aula208ExFixInterfaces.Services
{
    //Serviço de pagamento para calculo de taxas de juros do Paypal
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02; //variável do tipo double para porcentagem da taxa de juros do pagamento
        private const double InterestPercentage = 0.01; //variável do tipo double para porcentagem da taxa de juros simples mensal de cada parcela

        public double PaymentFee(double amount) //Taxa de juros do pagamento do valor total
        {
            return amount * FeePercentage;
        }

        public double Interest(double amount, int months) //Taxa de juros simples a cada parcela
        {
            return amount * InterestPercentage * months;
        }

    }
}
