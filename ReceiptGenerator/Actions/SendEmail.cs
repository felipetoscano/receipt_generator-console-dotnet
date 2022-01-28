namespace ReceiptGenerator.Actions
{
    public class SendEmail : IAction
    {
        public void Execute(Receipt receipt)
        {
            Console.WriteLine($"Enviando e-mail: {receipt.CorporateName}");
        }
    }
}
