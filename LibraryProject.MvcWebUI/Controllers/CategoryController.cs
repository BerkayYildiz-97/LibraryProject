using LibraryProject.MvcWebUI.Models.Entity;
using LibraryProject.MvcWebUI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryProject.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        BaseRepository<Category> categoryRepository = new BaseRepository<Category>();
        public ActionResult Index()
        {
            var categories = categoryRepository.GetList();
            return View(categories);
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            categoryRepository.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCategory(int id)
        {
            var updated = categoryRepository.GetById(id);
            return View(updated);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var deleted = categoryRepository.GetById(id);
            categoryRepository.Delete(deleted);

            return RedirectToAction("Index");
        }
    }
}