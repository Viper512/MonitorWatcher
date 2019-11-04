using MonitorWatcher.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MonitorWatcher.Util
{
    public static class FileUtil
    {
        public static MonitorValue FileCount(MonitorItem monitorItem)
        {
            string path = monitorItem.MonitorURL;

            MonitorValue output = new MonitorValue();

            output.MonitorItemID = monitorItem.ID;
            output.MonitorTime = System.DateTime.Now;

            try
            {
                if (!Directory.Exists(path))
                    output.Value = -1;

                output.Value = Directory.GetFiles(path).Length;
            }
            catch (Exception e)
            {
                output.Value = -2;
            }

            return output;
        }



    }
}