using DoAnCoSo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnCoSo.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new  ApplicationDbContext();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Detail(int id)
        {
            var item = db.Products.Find(id);
            return View(item);
        }

        public ActionResult Partial_ItemsByCateId() 
        {
            var items = db.Products.Where(x => x.IsHome && x.IsActive).Take(50).ToList();
            return PartialView(items);
        }
        //public ActionResult Partial_ItemsPSConsole()
        //{
        //    var items = db.Products.Where(x => x.IsHome && x.IsActive).Take(8).ToList();
        //    return PartialView(items);
        //}
    }
}