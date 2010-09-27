using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.DBConnections;
using Factory.DBConnections.secure;

namespace Factory.connectionFactories
{
    class SecureConnectionFactory : ConnectionFactory
    {
        public override Connection GetConnection( ConnectionType type )
        {
            switch( type )
            {
                case ConnectionType.Oracle:
                    return new OracleSecureConnection();
                case ConnectionType.Sql:
                    return new SqlSecureConnection();
            }
            return new MySqlSecureConnection();
        }
    }
}
