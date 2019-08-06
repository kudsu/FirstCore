using System;
using System.Collections.Generic;

namespace RMF.Servers.Models
{
    public partial class Invitation
    {
        public string Iid { get; set; }
        public string Icode { get; set; }
        public DateTime? Idate { get; set; }
        public string Isign { get; set; }
    }
}
