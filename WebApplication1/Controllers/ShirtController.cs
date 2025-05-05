using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    /*[Route("api/[controller]")]*/
    public class ShirtController:ControllerBase
    {
        /*[HttpGet]*/
        [HttpGet]
        [Route("/shirts")]
        public string GetShirt()
        {
            return "Reading all the shirts";
        }

        //[HttpGet("{id}")]
        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirt(int id)
        {
            return $"Reading the shirt with id :{id}";
        }
        //[HttpPost("{id}")]
        [HttpPost]
        [Route("/shirts")]
        public string createshirt()
        {
            return "Creating the shirts";
        }
        //[HttpPut("{id}")]
        [HttpPut]
        [Route("/shirts/{id}")]
        public string updateshirt(int id)
        {
            return $"Update the shirt";

        }
        /*[HttpDelete("{id}")]*/
        [HttpDelete]
        [Route("/shirts/{id}")]
        public string deleteShirt(int id)
        {
            return $"shirt deleted {id}";

        }

    }
}
