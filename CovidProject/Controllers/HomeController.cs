using CovidProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CovidProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {


            //   var data = await new HttpClient().GetStringAsync("https://api.covidtracking.com/v1/us/daily.json");
            var rootPath = _hostingEnvironment.ContentRootPath; //get the root path

            var fullPath = Path.Combine(rootPath, "data/json.json"); //combine the root path with that of our json file inside mydata directory

            var jsonData = System.IO.File.ReadAllText(fullPath); //read all the content inside the file

         

            var users = JsonConvert.DeserializeObject<List<DayStats>>(jsonData); //deserialize object as a list of users in accordance with your json file


            List<List<string>> data = new List<List<string>>();

            
            data.Add(users.Select(s => ((DateTime)s.dateChecked).ToShortDateString()).Take(10).ToList());
            data.Add(users.Select(s => s.positive.ToString()).Take(10).ToList());

            //return Ok(data);    
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}