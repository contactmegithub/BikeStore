using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
    public class CategoryReport
    {
        public string Category { get; set; }
        public int ProductCount { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
    }

    public class CustomerRegionReport
    {
        public string City { get; set; }
        public int CustomerCount { get; set; }
    }
    public class OrderByStore
    {
        public string StoreName { get; set; }
        public int OrderCount { get; set; }
    }
    public class ProductBrandPrices
    {
        public string BrandName { get; set; }
        public int ProductsCount { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
    }
}