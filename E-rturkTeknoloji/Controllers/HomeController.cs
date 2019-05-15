using E_rturkTeknoloji.Entity;
using E_rturkTeknoloji.Models;
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
            var products = _context.Products
                .Where(x => x.IsApproved && x.IsHome)
                .Select(x => new ProductModel()
                {
                    Id = x.Id,
                    Name = x.Name.Length > 50 ? x.Name.Substring(0,47)+"...":x.Name,
                    Description = x.Description.Length > 50 ? x.Description.Substring(0,47)+"...":x.Description,
                    Price = x.Price,
                    Image = x.Image == null ? "1.jpg" : x.Image,
                    Stock = x.Stock,
                    CategoryId = x.CategoryId
                    
                }).ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            var productDetail = _context.Products.Where(i => i.Id == id).FirstOrDefault();

            return View(productDetail);
        }
        public ActionResult List(int? id)
        {
            var products = _context.Products
               .Where(x => x.IsApproved)
               .Select(x => new ProductModel()
               {
                   Id = x.Id,
                   Name = x.Name.Length > 50 ? x.Name.Substring(0, 47) + "..." : x.Name,
                   Description = x.Description.Length > 50 ? x.Description.Substring(0, 47) + "..." : x.Description,
                   Price = x.Price,
                   Image = x.Image == null ? "1.jpg":x.Image,
                   Stock = x.Stock,
                   CategoryId = x.CategoryId

               }).AsQueryable(); //sorgulamaya devam edebilirim.
            if (id !=null)
            {
                products = products.Where(i => i.CategoryId == id);
            }
            return View(products);

        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
        // deneme/2/2/2
    }
}