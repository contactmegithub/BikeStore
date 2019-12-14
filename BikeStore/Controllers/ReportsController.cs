using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStore.DataAccess;
using BikeStore.Models;
using Newtonsoft.Json;

namespace BikeStore.Controllers
{
    public class ReportsController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: Reports
        public ActionResult Category()
        {
            ViewBag.Message = "Products Category";
            var result = db.categories.GroupBy(g => g.category_id).Select(r => new CategoryReport()
            {
                Category = r.FirstOrDefault().category_name,
                ProductCount = r.FirstOrDefault().products.Count(),
                AvgPrice = r.FirstOrDefault().products.Average(a => a.list_price),
                MaxPrice = r.FirstOrDefault().products.Max(a => a.list_price),
                MinPrice = r.FirstOrDefault().products.Min(a => a.list_price)
            });
            //var materialOptions = new {
            //chart: {
            //title: 'Population of Largest U.S. Cities',
            //    subtitle: 'Based on most recent and previous census data'
            //},
            //hAxis:
            //{
            //title: 'Total Population',
            //    minValue: 0,
            //},
            //vAxis:
            //{
            //title: 'Category'
            //},
            //bars: 'horizontal'
            //};
            ViewBag.data = JsonConvert.SerializeObject(result);
            return View(result);
        }

        public ActionResult CustomerRegion()
        {
            ViewBag.Message = "Customers By Region";
            var result = db.customers.GroupBy(g => g.state).Select(r => new CustomerRegionReport
            () {
                City = r.Key,
                CustomerCount = r.Count()
            });
            return View(result);
        }

        public ActionResult OrderByStore()
        {
            ViewBag.Message = "Orders By Store";
            var result = db.orders.GroupBy(g => g.store_id).Select(r => new OrderByStore
            ()
            {
                StoreName = r.FirstOrDefault().store.store_name,
                OrderCount = r.Count()
            });
            return View(result);
        }

        public ActionResult ProductBrandPrices()
        {
            ViewBag.Message = "Products price by Brand";
            var result = db.products.GroupBy(g => g.brand_id).Select(r => new ProductBrandPrices
            (){
                BrandName=r.FirstOrDefault().brand.brand_name,
                ProductsCount = r.Count(),
                AveragePrice=r.Average(a => a.list_price),
                MinPrice=r.Min(a => a.list_price),
                MaxPrice=r.Max(a => a.list_price)
            });
            return View(result);
        }
    }
}