using System;
using System.Collections.Generic;

namespace AdventureWorks.EfData
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public int? CrustId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Active { get; set; }
        public int? ComputedName { get; set; }

        public Crust Crust { get; set; }
        public ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
