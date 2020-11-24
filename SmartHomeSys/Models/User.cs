using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartHomeSys.Models
{
    class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }


        public virtual List<Cluster> AccesibleClusters { get; set; }
    }
}
