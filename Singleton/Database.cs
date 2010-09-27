using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Database
    {
        private static readonly object InstanceLocker = new object();
        private int record;
        private static Database database;

        private Database( string name )
        {
            Name = name;
            record = 0;
        }

        public string Name
        {
            get; private set;
        }

        public static Database GetInstance( String name )
        {
            if( database != null ) return database;

            lock( InstanceLocker )
            {
                database = database ?? new Database( name );
                return database;
            }
        }

        public void EditRecord( String operation )
        {
            Console.WriteLine( "Performing {0} on record {1} in database {2}", operation, record, Name );
        }
    }
}
