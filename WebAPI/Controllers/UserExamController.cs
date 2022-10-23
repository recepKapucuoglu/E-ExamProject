using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserExamController : ControllerBase
    {
        IUserExamService _userExamService;

        public UserExamController(IUserExamService userExamService)
        {
            _userExamService = userExamService;
        }


        [HttpGet("userexamget")]
        public IActionResult GetUserExam(int userid)
        {
            var result = _userExamService.GetExamForUser(userid);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
