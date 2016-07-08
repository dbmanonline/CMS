using AutoMapper;
using CMS.Domains;
using CMS.Interfaces;
using CMS.Web.Areas.Admin.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CMS.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Admin/Category
        public ActionResult Index()
        {
            var categories = _categoryService.GetAll();
            //var categoryModels = Mapper.Map<List<Category>, List<CategoryViewModel>>(categories.ToList());
            return View(categories);
        }
    }
}