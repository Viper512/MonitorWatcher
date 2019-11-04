using MonitorWatcher.Models;
using MonitorWatcher.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWatcher.DAL
{
    public static class DALMonitor
    {
        public static IEnumerable<MonitorItem> GetMonitorItems()
        {
            Console.WriteLine("Getting Monitor Items");

            return DBUtil.GetMonitorItems();
        }
        public static void SaveData(DateTime MonitorStartTime, MonitorValue monitorValue)
        {
            DBUtil.SaveData(MonitorStartTime, monitorValue);
        }

    }
}
