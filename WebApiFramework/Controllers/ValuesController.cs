using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Transactions;
using System.Web.Http;

namespace WebApiFramework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public class Filter
        {
            public byte[] Token { get; set; }
        }

        // POST api/values
        public void Post([FromBody] Filter filter)
        {
            var dtcTransction = TransactionInterop.GetTransactionFromTransmitterPropagationToken(filter.Token);
            using (var context = new TransactionScope(dtcTransction))
            {
                dtcTransction.TransactionCompleted += DtcTransction_TransactionCompleted;
                context.Complete();
            }
        }

        private void DtcTransction_TransactionCompleted(object sender, TransactionEventArgs e)
        {
            Console.WriteLine("ApiCompleted");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
