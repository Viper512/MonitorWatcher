using MonitorWatcher.DAL;
using MonitorWatcher.Models;
using MonitorWatcher.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWatcher.BLL
{
    public static class BLLMonitor
    {
        public static void RecordData()
        {
            DateTime MonitorStartTime = System.DateTime.Now;

            foreach (MonitorItem monitorItem in DALMonitor.GetMonitorItems())
            {
                DALMonitor.SaveData(MonitorStartTime, FileUtil.FileCount(monitorItem));
            }
        }
    }
}
