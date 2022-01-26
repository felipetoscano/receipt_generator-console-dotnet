namespace ReceiptGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var receiptBuilder = new ReceiptBuilder();

            receiptBuilder
                .WithCorpotateName("Extra")
                .WithCnpj("20.780.628/0001-64")
                .WithDate(DateTime.Now.AddDays(-10))
                .With(new ItemBuilder().WithName("Caneta").WithValue(2.00).Build())
                .With(new ItemBuilder().WithName("Lápis").WithValue(1.00).Build())
                .WithObservations("Cliente Clube Extra");

            var receipt = receiptBuilder.Build();

            Console.WriteLine(receipt);
        }
    }
}