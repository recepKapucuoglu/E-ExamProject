using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*category/getall*/
        public IActionResult GetAll()

        {
            _categoryService.GetAll();
            return View();
            //if (result.Success)
            //    return Ok(result);
            //else { return BadRequest(result); }
        }
    }
}
