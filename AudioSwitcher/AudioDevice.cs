using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioSwitcher
{
    public class AudioDevice
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public bool IsInUse { get; set; }
        public bool IsSelected { get; set; }
    }
}
