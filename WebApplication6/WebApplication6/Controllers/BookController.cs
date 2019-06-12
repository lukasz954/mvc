using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Repository;

namespace WebApplication6.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var repository = new BookRepository();
            ViewBag.Books = repository.Get();
            return View();
        }
    }
}