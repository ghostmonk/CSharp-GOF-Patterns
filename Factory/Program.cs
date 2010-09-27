using System;
using Factory.connectionFactories;
using Factory.DBConnections;

namespace Factory
{
    class Program
    {
        public Program()
        {
            ConnectionFactory factory;
            factory = new SecureConnectionFactory();
            Connection connection = factory.GetConnection( ConnectionType.Oracle );
            Console.WriteLine( connection.Description() );
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
