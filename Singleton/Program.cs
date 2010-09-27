using System;

namespace Singleton
{
    class Program
    {
        public Program()
        {
            Database data = Database.GetInstance( "products" );
            TestDatabase();
        }

        private void TestDatabase()
        {
            Database data = Database.GetInstance( "employees" );
            Console.WriteLine( "Database name is {0}", data.Name );
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
