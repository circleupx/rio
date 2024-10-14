namespace Rio
{
    internal interface ITransactionParser{
        Transaction Parse(string message);
    }   
}