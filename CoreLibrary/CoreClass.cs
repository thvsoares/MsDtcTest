using System;
using System.Transactions;

namespace CoreLibrary
{
    public class CoreClass
    {
        public static void Hello()
        {
            Console.WriteLine("Hello 5.0");
        }

        //public static byte[] GetTrasactionToken()
        //{
        //    using var scope = new TransactionScope();
        //    var transction = Transaction.Current;
        //    return TransactionInterop.GetTransmitterPropagationToken(transction);
        //}
    }
}
