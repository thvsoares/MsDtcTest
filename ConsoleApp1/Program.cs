using FrameworkLibrary;
using Newtonsoft.Json;
using StandardLibrary;
using System;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CoreClass.Hello();
            StandardClass.Hello();
            FrameworkClass.Hello();
            //var t0 = CoreClass.GetTrasactionToken();
            var t1 = StandardClass.GetTrasactionToken();
            var t2 = FrameworkClass.GetTrasactionToken();

            using (var client = new HttpClient())
            {
                var url = "http://WebApiFramework/api/Values/2";
                var data = JsonConvert.SerializeObject(new { token = t1 });
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = client.PostAsync(url, content).Result;
                Console.WriteLine(result.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
