using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWatcher.Models
{
    public class MonitorValue
    {
        public int MonitorItemID;
        public DateTime MonitorTime = System.DateTime.Now;
        public int Value;
    }
}
