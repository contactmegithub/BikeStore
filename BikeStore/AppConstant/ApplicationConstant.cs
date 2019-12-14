using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.AppConstant
{
    public class ApplicationConstant
    {
        public static string ChartOptions = @"
            {
                chart: {
            title: 'Products price by Brand',
                subtitle: 'Product cost comparision between brands',
                },
            hAxis:
            {
            title: 'Max Price',
                minValue: 0,
            },
            vAxis:
            {
            title: 'Brand Name'
            },
            bars: 'horizontal'
            }";
    }
}