using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using WebApplication6.Repository;

namespace WebApplication6.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var repo = new UserRepository();
            if(string.IsNullOrEmpty(user.Login) && string.IsNullOrEmpty(user.Password))
                return RedirectToAction("Index");
            var us = repo.Get().Where(c => c.Login.Contains(user.Login) && c.Password.Contains(user.Password));
            if (us.Count() > 0)
            {
                var userData = repo.Get().FirstOrDefault(x => x.Login.Contains(user.Login) && x.Password.Contains(user.Password));
                return RedirectToAction("LoginSuccess", userData);
            }
            else
                return RedirectToAction("Index");
        }
        
        public ActionResult LoginSuccess(User user)
        {
            var orderRepo = new OrderRepository();
            var bookRepo = new BookRepository();

            var userBooks = orderRepo.Get().Where(x => x.UserId == user.Id);
            var listBook = new List<Book>();
            foreach (Order item in userBooks)
            {
                foreach (var book in item.BookId)
                {
                    var booksThisUser = bookRepo.GetById(book);
                    listBook.Add(booksThisUser);
                }
            }
            ViewBag.UserBooks = listBook;
            return View();
        }

    }
}