using System.Text;

namespace ReceiptGenerator
{
    public class Item
    {
        public string Name { get; private set; }
        public double Value { get; private set; }

        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .Append($"Name: {Name}, ")
                .Append($"Value: {Value}");

            return stringBuilder.ToString();
        }
    }
}
