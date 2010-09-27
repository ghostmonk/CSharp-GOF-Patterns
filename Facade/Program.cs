using System;
using Facade.products;

namespace Facade
{
    class Program
    {
        public Program()
        {
            ISimpleProduct product = new SimpleProduct();
            product.SetName( "printer" );
            Console.WriteLine( product.GetName() );
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
