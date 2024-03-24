using Microsoft.AspNetCore.Mvc;
using News.API.Models;

namespace News.API.Controllers
{
    [ApiController]
    [Route("api/news")]
    public class NewsController:ControllerBase
    {
        [HttpGet]
        public ActionResult GetNews()
        {
            return Ok(new List<TechNews>(){
                new TechNews(){
                    NewsId = 101,
                    NewsTitle = "News1"
                },
                new TechNews(){
                    NewsId = 102,
                    NewsTitle = "News2"
                }
            });
        }
    }
}