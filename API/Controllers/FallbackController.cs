using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //when api doesnt know what to do with the routes, it sends it
    //to the angular index.html which knows what to do
    public class FallbackController :  Controller
    {
        public ActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "index.html"), "text/html");
        }
    }
}