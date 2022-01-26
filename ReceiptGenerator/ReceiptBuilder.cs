using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptGenerator
{
    public class ReceiptBuilder
    {
        private string corporateName;
        private string cnpj;
        private DateTime issueDate;
        private double totalValue;
        private double taxesValue;
        private string observations;
        private readonly IList<Item> itens;

        public ReceiptBuilder()
        {
            corporateName = "";
            cnpj = "";
            observations = "";
            issueDate = DateTime.Now;
            itens = new List<Item>();
        }

        public Receipt Build()
        {
            return new Receipt(corporateName, cnpj, issueDate, totalValue, taxesValue, observations, itens);
        }

        public ReceiptBuilder WithCorpotateName(string corporateName)
        {
            this.corporateName = corporateName;
            return this;
        }

        public ReceiptBuilder WithCnpj(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public ReceiptBuilder WithDate(DateTime date)
        {
            issueDate = date;
            return this;
        }

        public ReceiptBuilder WithObservations(string observations)
        {
            this.observations = observations;
            return this;
        }

        public ReceiptBuilder With(Item item)
        {
            itens.Add(item);
            totalValue += item.Value;
            taxesValue += item.Value * 0.05;
            return this;
        }
    }
}
