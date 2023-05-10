namespace ReceiptGenerator.Actions
{
    public class Print : IAction
    {
        public void Execute(Receipt receipt)
        {
            Console.WriteLine($"Imprimindo recibo: {receipt.CorporateName}");
        }
    }
}
