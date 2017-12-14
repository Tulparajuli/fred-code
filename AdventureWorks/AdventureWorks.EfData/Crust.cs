using System;
using System.Collections.Generic;

namespace AdventureWorks.EfData
{
    public partial class Crust
    {
        public Crust()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }

        public ICollection<Pizza> Pizza { get; set; }
    }
}
