using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSale.Models
{
    public class Product
    {
        public Product(string productCode, decimal unitPrice)
        {
            ProductCode = productCode;
            UnitPrice = UnitPrice;
        }

        public Product(string productCode, decimal unitPrice, int bulkQuantity, decimal bulkPrice)
        {
            ProductCode = productCode;
            UnitPrice = UnitPrice;
            BulkPrice = new BulkPrice(bulkQuantity, bulkPrice);
        }

        public string ProductCode { get; set; }
        public decimal UnitPrice { get; set; }
        public BulkPrice BulkPrice { get; set; }
    }
}