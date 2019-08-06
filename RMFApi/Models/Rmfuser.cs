using System;
using System.Collections.Generic;

namespace RMFApi.Models
{
    public partial class Rmfuser
    {
        public string Rid { get; set; }
        public string Rname { get; set; }
        public string Rpwd { get; set; }
        public string Rsign { get; set; }
    }
}
