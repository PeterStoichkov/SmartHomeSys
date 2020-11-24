using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSys.Models
{
    class Lamp : Device
    {
        public int LampId { get; set; }
        public string Colour { get; set; }
    }
}
