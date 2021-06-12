using System;
using System.Transactions;

namespace FrameworkLibrary
{
    public class FrameworkClass
    {
        public static void Hello()
        {
            Console.WriteLine("Hello framework");
        }

        public static byte[] GetTrasactionToken()
        {
            using (var scope = new TransactionScope())
            {
                var transction = Transaction.Current;
                return TransactionInterop.GetTransmitterPropagationToken(transction);
            }
        }
    }
}
