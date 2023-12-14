using Aula208ExFixInterfaces.Entities;

namespace Aula208ExFixInterfaces.Services
{
    //Classe de serviço do contrato
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService; //Instanciando a interface de serviço de pagamento

        //Construtors
        public ContractService(IOnlinePaymentService onlinePaymentService) //Construtor com a interface como argumento
        {
            _onlinePaymentService = onlinePaymentService;
        }


        //Método para fazer o processamento de pagamento do contrato
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months; //BasicQuota do tipo double para dividir o valor total do contrato em meses a serem parcelados

            //Estrutura de repetição para adicionar à parcela o número de meses declarados
            for (int i = 1; i <= months; i++) //Para i = 1 até i <= months faça
            {
                DateTime date = contract.Date.AddMonths(i); //propriedade do tipo DateTime para pegar a data do contrato e adicionar mês no valor de i (data da parcela mensal)
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i); //Propriedade na qual atualiza a parcela pegando a parcela básica (basicQuota) e somando ao serviço de pagamento com o método de juros mensal com a basicQuota e o mês de referência como argumentos
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota); //Propriedade na qual soma a parcela mensal total, somando a parcela atualizada (updateQuota) acima + o serviço de pagamento com o método taxa de pagamento (PaymentFee) para o valor total com o updateQuota de argumento

                contract.AddInstallment(new Installment(date, fullQuota)); //Chamando o método da classe contrato para adicionar a parcela à lista de parcelas da classe, com a data e a parcela total (fullQuota) de argumentos
            }

        }
    }
}
