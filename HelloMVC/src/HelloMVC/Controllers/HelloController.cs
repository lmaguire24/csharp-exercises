using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [Route("/hello")]
        [HttpGet]
        public IActionResult Index(string name = "language")
        {
            string html = "<form method=\"post\" action=\"/hello\">" +
                "<input type=\"text\" name=\"name\" />" +
                 "<select name = 'language'>" +
                 "<option value ='English'> English </option>" +
                 "<option value = 'Spanish'> Spanish </option>" +
                 "<option value = 'French'> French </option>" +
                 "<option value = 'Dutch'> Dutch </option>" +
                 "<option value = 'Italian'> Italian </option> </select>" +
                "<input type=\"submit\" value=\"Greet me!\" />" +
                "</form>";

            return Content(html, "text/html");
        }

        [Route("/hello")]
        [HttpPost]
        public IActionResult Display(string name, string language)
        {
            string greeting = "";
            switch (language)
            {
                case "English":
                    greeting = "Hello";
                    break;
                case "Spanish":
                    greeting = "Hola";
                    break;
                case "French":
                    greeting = "Bonjour"; 
                    break;
                case "Dutch":
                    greeting = "Hallo";
                    break;
                case "Italian":
                    greeting = "Cioa";
                    break;
            }
            return Content(string.Format("<h1>{0} {1}</h1>", greeting, name), "text/html");
            //return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // Handle requests to /hello/nick (URL segment)
        [Route("/hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        // GET: /hello/aloha
        [Route("/hello/aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
