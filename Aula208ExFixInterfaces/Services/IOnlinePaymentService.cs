namespace Aula208ExFixInterfaces.Services
{
    //Interface para conjunto de operações de pagamento a serem implementados sem fazer com que o serviço tenha uma dependecia concreta do serviço a ser operado
    interface IOnlinePaymentService 
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
