using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSale
{
    public class ProgramEntry
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