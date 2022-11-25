using Suncor_LdtConduitesLibrary.DataAccess;
using System.Configuration;

namespace Suncor_LdtConduitesLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(bool database)
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        public static string conString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
