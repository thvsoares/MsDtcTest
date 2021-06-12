using CoreLibrary;
using FrameworkLibrary;
using StandardLibrary;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreClass.Hello();
            StandardClass.Hello();
            FrameworkClass.Hello();
            //_ = CoreClass.GetTrasactionToken();
            //_ = StandardClass.GetTrasactionToken();
            _ = FrameworkClass.GetTrasactionToken();
        }
    }
}
