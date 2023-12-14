using System.Globalization;
using System.Collections.Generic;
using Aula208ExFixInterfaces.Entities;
using Aula208ExFixInterfaces.Services;

namespace Aula208ExFixInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inserindo dados do contrato
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime dateContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Inserindo a quantidade de parcelas do contrato a serem pagas
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            //Isntanciando a classe contrato com o número, data e valor como argumentos
            Contract contract = new Contract(contractNumber, dateContract, contractValue);

            //Isntanciando o serviço de contrato com uma nova instanciação do Paypalservice como argumento
            ContractService contractService = new ContractService(new PaypalService());

            //Instanciando o método do serviço de contrato com a classe contrato e a quantidade de meses como argumentos
            contractService.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            //Laço para cada parcela (Installment) da classe Installment em parcelas(lista Installemnts dentro da classe Contract) faça
            foreach(Installment installment in contract.Installments)
            {
                //Mostra na tela os dados da lista installment convertidos para string
                Console.WriteLine(installment);
            }

        }
    }
}