using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        IProductService _productService;
//        public ProductController(IProductService productService)
//        {
//           _productService=productService;
//        }
//        [HttpGet("getall")]
//        public IActionResult GetAll()
//        {
//            var result=_productService.GetAll();

//            if (result.Success)
//                return Ok(result);
//            else { return BadRequest(result); }
//        }
//        [HttpGet("getallbycategoryıd")]

//        public IActionResult GetAllByCategoryId(int id)
//        {
//            var result = _productService.GetAllByCategoryId(id);

//            if(result.Success) return Ok(result);   
//            else return BadRequest(result); 
//        }
//        [HttpGet("getbyunitprice")]

//        public IActionResult GetByUnitPrice(decimal min, decimal max)
//        {
//            var result = _productService.GetByUnitPrice(min, max);

//            if (result.Success) return Ok(result);
//            else return BadRequest(result);
//        }
//    }
}
