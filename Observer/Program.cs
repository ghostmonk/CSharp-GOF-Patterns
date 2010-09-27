using System;
using Observer.observers;
using Observer.subjects;

namespace Observer
{
    class Program
    {
        public Program()
        {
            Database database = new Database();
            database.RegisterObserver( new Client() );
            database.RegisterObserver( new Archiver() );
            database.RegisterObserver( new Boss() );
            database.EditRecord( "delete", "record 1" );
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}