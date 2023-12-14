using System;
using System.Collections.Generic;
using Aula208ExFixInterfaces.Entities;
using System.Globalization;

namespace Aula208ExFixInterfaces.Entities
{
    class Contract
    {
        public int Number { get; set; } //Propriedade do tipo inteiro do número do contrato
        public DateTime Date { get; set; } //Propriedade do tipo DateTime para a data do contrato
        public double TotalValue { get; set; } //Propriedade do tipo double para valor total do contrato
        public List<Installment> Installments { get; set; } //Lista do tipo classe Installment (parcelas) para uma lista de parcelas

        //Construtor declarado sem a propriedade para-muitos Installments como argumento, porém instanciada dentro do construtor
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>(); //Instanciando a lista dentro do construtor
        }

        //Método para adicionar a lista um Installment
        public void AddInstallment(Installment installment) //Método para adicionar parcelas
        {
            Installments.Add(installment);
        }
    }
}
