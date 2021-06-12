using System;
using System.Transactions;

namespace CoreLocal
{
    class Program
    {
        static void Main(string[] args)
        {
            using var scope = new TransactionScope();
            var transction = Transaction.Current;
            var dtc = TransactionInterop.GetTransmitterPropagationToken(transction);
        }
    }
}
