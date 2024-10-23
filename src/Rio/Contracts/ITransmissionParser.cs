using Rio.Models;

namespace Rio.Contracts
{
    internal interface ITransmissionParser{
        Transaction Parse(string message);
    }   
}