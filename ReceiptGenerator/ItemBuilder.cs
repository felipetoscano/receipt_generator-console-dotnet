namespace ReceiptGenerator
{
    public class ItemBuilder
    {
        public string name;
        public double value;

        public ItemBuilder()
        {
            name = "";
        }

        public Item Build()
        {
            return new Item(name, value);
        }

        public ItemBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ItemBuilder WithValue(double value)
        {
            this.value = value;
            return this;
        }
    }
}
