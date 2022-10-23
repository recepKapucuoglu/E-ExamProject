using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVCPage.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Getall()
        {
         var result=   _categoryService.GetAll();
            return View(result);
        }
    }
}
