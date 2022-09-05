using Microsoft.AspNetCore.Mvc;
using PJC.Models;
using System;

namespace PJC.Areas.PageReview
{
    [Area("PageReview")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(PJC.Models.StoreContext)) as StoreContext;
            return View(context.GetSanPham());
        }

        [HttpPost]
        public void AddToCart(string code)
        {
            System.Diagnostics.Debug.WriteLine(code);
        }
    }
}
