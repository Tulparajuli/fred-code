﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.EfData
{
    public partial class PizzaTopping
    {
        public int PizzaToppingId { get; set; }
        public int PizzaId { get; set; }
        public int ToppingId { get; set; }

        public Pizza Pizza { get; set; }
        public Topping Topping { get; set; }
    }
}
