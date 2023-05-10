using ReceiptGenerator.Actions;

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
        private IList<IAction> actions;

        public ReceiptBuilder(IList<IAction> actions)
        {
            corporateName = "";
            cnpj = "";
            observations = "";
            issueDate = DateTime.Now;
            itens = new List<Item>();
            this.actions = actions;
        }

        public Receipt Build()
        {
            var receipt = new Receipt(corporateName, cnpj, issueDate, totalValue, taxesValue, observations, itens);

            foreach (var action in actions)
            {
                action.Execute(receipt);
            }

            return receipt;
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
