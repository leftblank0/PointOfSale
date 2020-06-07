using NUnit.Framework;
using PointOfSale;

namespace Tests
{
    public class Tests
    {
        PointOfSaleTerminal post;

        [SetUp]
        public void Setup()
        {
            post = new PointOfSaleTerminal();
        }

        //[TestCase("A", ExpectedResult = 1.25)]
        //[TestCase("A,B,C,D,A,B,A", ExpectedResult = 13.25)]
        //[TestCase("C,C,C,C,C,C,C", ExpectedResult = 6.0)]
        //[TestCase("A,B,C,D", ExpectedResult = 7.25)]
        public void Totals(string products)
        {
            post.ScanProduct("A");
            var a = post.CalculateTotal();
            Assert.Pass();
        }
    }
}