using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSys.Models
{
    class Lock : Device
    {
        public int LockId { get; set; }
        public string PinCode { get; set; }
    }
}
