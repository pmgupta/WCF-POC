using System;

namespace MyWCFConsoleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ServiceReference1.MyBasicWCFServiceClient proxy = new ServiceReference1.MyBasicWCFServiceClient();
            var msg = proxy.GetData(101);
            Console.WriteLine(msg);
            Console.ReadKey();

        }
    }
}
