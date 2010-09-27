using Factory.DBConnections;
using Factory.DBConnections.simple;

namespace Factory.connectionFactories
{
    class ConnectionFactory
    {
        public virtual Connection GetConnection( ConnectionType type )
        {
            switch( type )
            {
                case ConnectionType.Oracle:
                    return new OracleConnection();
                case ConnectionType.Sql:
                    return new SqlConnection();
            }
            return new SqlConnection();
        }
    }
}
