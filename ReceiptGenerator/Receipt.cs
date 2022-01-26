using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptGenerator
{
    public class Receipt
    {
        public string CorporateName { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime IssueDate { get; private set; }
        public double TotalValue { get; private set; }
        public double TaxesValue { get; private set; }
        public string Observations { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Receipt(
            string corporateName, 
            string cnpj, 
            DateTime issueDate, 
            double totalValue, 
            double taxesValue, 
            string observations, 
            IList<Item> itens)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            IssueDate = issueDate;
            TotalValue = totalValue;
            TaxesValue = taxesValue;
            Observations = observations;
            Itens = itens;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .Append($"CorporateName: {CorporateName}\n")
                .Append($"CNPJ: {Cnpj}\n")
                .Append($"IssueDate: {IssueDate}\n")
                .Append($"TotalValue: {TotalValue}\n")
                .Append($"TaxesValue: {TaxesValue}\n")
                .Append($"Observations: {Observations}\n");

            foreach(var item in Itens)
            {
                stringBuilder.Append($"Item -> {item}\n");
            }

            return stringBuilder.ToString();
        }
    }
}
