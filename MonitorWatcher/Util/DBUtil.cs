using MonitorWatcher.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWatcher.Util
{
    static class DBUtil
    {
        static private string connectionString = ConfigurationManager.AppSettings["connString"];

        static private SqlConnection connection = new SqlConnection(connectionString);

        static private DataContext dc = new DataContext(connection);
        public static IEnumerable<MonitorItem> GetMonitorItems()
        {
            var MonitorItems = dc.ExecuteQuery<MonitorItem>(@"Select ID, Description, MonitorURL from MonitorItem");

            return MonitorItems;
        }

        public static void SaveData(DateTime MonitorStartTime, MonitorValue monitorValue)
        {
            dc.ExecuteCommand("Insert into MonitorItemValues (MonitorItemID, MonitorStartTime, MonitorTime, Value) values ({0}, {1}, {2}, {3})",
                                                    monitorValue.MonitorItemID, MonitorStartTime, monitorValue.MonitorTime, monitorValue.Value);              
        }
    }
}
