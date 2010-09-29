using System;

namespace ProxyClient
{
    class Program
    {
        public Program()
        {
            AutomatProxy proxy = new AutomatProxy();
            proxy.Run();
            proxy.GotApplication();
            proxy.CheckApplication();
            //proxy.RentApartment();
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
