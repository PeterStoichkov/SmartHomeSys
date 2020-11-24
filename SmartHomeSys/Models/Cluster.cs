using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartHomeSys.Models
{
    class Cluster
    {
        [Key]
        public int ClusterId { get; set; }
        public List<IDevice> Devices { get; set; }
    }
}
