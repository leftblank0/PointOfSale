﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            PointOfSaleTerminal post = new PointOfSaleTerminal();
            post.SetPricing();

            var a = post.CalculateTotal();
            var b = a;
        }
    }
}
