﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetProject
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
