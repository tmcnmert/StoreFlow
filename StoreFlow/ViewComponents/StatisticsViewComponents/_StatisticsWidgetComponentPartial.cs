using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents.StatisticsViewComponents
{
    public class _StatisticsWidgetComponentPartial:ViewComponent
    {
        public readonly StoreContext _context;

        public _StatisticsWidgetComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
          ViewBag.CategoryCount = _context.Categories.Count();
            ViewBag.ProductMaxPrice = _context.Products.Max(p => p.ProductPrice);  
            ViewBag.ProductMinPrice = _context.Products.Min(p => p.ProductPrice);

            ViewBag.ProductMaxPriceProductName = _context.Products.Where(x => x.ProductPrice == (_context.Products.Max(y => y.ProductPrice))).Select(z =>z.ProductName).FirstOrDefault();


            ViewBag.ProductMinPriceProductName =_context.Products.Where(x=>x.ProductPrice==(_context.Products.Min(y=>y.ProductPrice))).Select(z=>z.ProductName).FirstOrDefault();

            ViewBag.TotalSumProductStock = _context.Products.Sum(p => p.ProductStock);
            ViewBag.averageProductStock = _context.Products.Average(x => x.ProductStock);
            ViewBag.averageProductPrice = _context.Products.Average(x => x.ProductPrice);

            ViewBag.biggerPriceThen1000ProductCount = _context.Products.Where(x => x.ProductPrice > 1000).Count();
            ViewBag.getIDIs4ProductName = _context.Products.Where(x => x.ProductId == 4).Select(y => y.ProductName).FirstOrDefault();
            ViewBag.stockCountBigger50AndSmaller100ProductCount = _context.Products.Where(x => x.ProductStock > 50 && x.ProductStock < 100).Count();

            return View();
        }
    }
}
