using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCategoryController : ControllerBase
    {
        
        IQuestionCategoryService _questionCategoryService;

        public QuestionCategoryController(IQuestionCategoryService questionCategoryService)
        {
            _questionCategoryService = questionCategoryService;
        }

        [HttpPost("ekle")]
        public IActionResult Add(QuestionCategoryDetailDto questionCategoryDetailDto)
        {
            var result = _questionCategoryService.Add(questionCategoryDetailDto);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("listele")]
        public IActionResult GetAll()

        {
            var result = _questionCategoryService.GetAll();
            if (result.Success)
                return Ok(result);
            else { return BadRequest(result); }
        }



        //public IActionResult GetAll()
        //{
        //    var result = _questionCategoryService.();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return BadRequest(result);
        //    }
        //}

    }
}
