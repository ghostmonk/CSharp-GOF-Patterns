using System;
using Iterator.corporation;
using Iterator.utils;

namespace Iterator
{
    class Program
    {
        public Program()
        {
            //This is the Java style of iteration... .NET uses Enumerator
            EmployeeCollection collection = new EmployeeCollection();
            collection.Add( new Employee( "Bob", Division.Sales ) );
            collection.Add( new Employee( "Ted", Division.Custodial ) );
            collection.Add( new Employee( "Carol", Division.CustomerRelations ) );
            collection.Add( new Employee( "Alice", Division.Management ) );

            var iterator = collection.Iterator();

            while( iterator.HasNext() )
            {
                ( (Employee)iterator.Next() ).Print();
            }
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
