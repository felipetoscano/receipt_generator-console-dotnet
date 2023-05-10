namespace ReceiptGenerator.Actions
{
    public class SendSms : IAction
    {
        public void Execute(Receipt receipt)
        {
            Console.WriteLine($"Enviando SMS: {receipt.CorporateName}");
        }
    }
}
