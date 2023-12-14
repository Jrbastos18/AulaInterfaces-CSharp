using System.Globalization;

namespace Aula208ExFixInterfaces.Entities
{
    class Installment
    {
        //Classe de parcelas declarando a data de vencimento (due date) e o valor (amount)
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        //Construtor da classe
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        //Método para converter dados da classe e retornar como string
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
