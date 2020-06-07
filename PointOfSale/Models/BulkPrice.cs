using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSale.Models
{
    public class BulkPrice
    {
        public BulkPrice(int bulkQuantity, decimal bulkPrice)
        {
            Quantity = bulkQuantity;
            Price = bulkPrice;
        }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}