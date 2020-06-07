using PointOfSale.Models;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        private List<Product> products;
        private Order order;

        public PointOfSaleTerminal()
        {
        }

        public void SetPricing()
        {
            products.Add(new Product("A", 1.25m, 3, 3.00m));
            products.Add(new Product("B", 4.25m));
            products.Add(new Product("C", 1.25m, 6, 5.00m));
            products.Add(new Product("D", 0.75m));
        }

        public void ScanProduct(string productCode)
        {
            order.Add(products.FirstOrDefault(x => x.ProductCode == productCode));
        }

        public decimal CalculateTotal()
        {
            decimal sum = 0;

            foreach(Product product in products)
            {
                sum += product.UnitPrice;
            }

            return sum;
        }
    }
}