using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSale.Models
{
    public class Order
    {
        public List<Product> Products;

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}