using E_rturkTeknoloji.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_rturkTeknoloji.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var products = _context.Products.Where(x => x.IsApproved && x.IsHome).ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            var productDetail = _context.Products.Where(i => i.Id == id).FirstOrDefault();

            return View(productDetail);
        }
        public ActionResult List()
        {
            var products = _context.Products.Where(x => x.IsApproved).ToList();
            return View(products);
            
        }
    }
}