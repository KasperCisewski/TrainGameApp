using Microsoft.AspNetCore.Mvc;

namespace TrainQuiz_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
           return "Working Happily";
        }
    }
}