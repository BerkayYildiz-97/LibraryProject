using LibraryProject.MvcWebUI.Models.Entity;
using LibraryProject.MvcWebUI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryProject.MvcWebUI.Controllers
{
    public class BookController : Controller
    {
        BaseRepository<Book> bookRepository = new BaseRepository<Book>();
        BaseRepository<Category> categoryRepository = new BaseRepository<Category>();
        public ActionResult Index()
        {
            ViewBag.Categories = categoryRepository.GetList();
            var books = bookRepository.GetList();
            return View(books);
        }

        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            bookRepository.Add(book);

            return RedirectToAction("Index");
        }

        public ActionResult UpdateBook(int id)
        {
            var updated = bookRepository.GetById(id);
            return View(updated);
        }

        [HttpPost]
        public ActionResult UpdateBook(Book book)
        {
            bookRepository.Update(book);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteBook(int id)
        {
            var deleted = bookRepository.GetById(id);
            bookRepository.Delete(deleted);

            return RedirectToAction("Index");
        }
    }
}