using System;
using System.Transactions;

namespace StandardLibrary
{
    public class StandardClass
    {
        public static void Hello()
        {
            Console.WriteLine("Hello standard 2.0");
        }

#if NETSTANDARD
        public static byte[] GetTrasactionToken()
        {
            using (var scope = new TransactionScope())
            {
                var transction = Transaction.Current;
                return TransactionInterop.GetTransmitterPropagationToken(transction);
            }
        }
#endif
    }
}
