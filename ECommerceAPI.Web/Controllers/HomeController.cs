using ECommerce.Application.DTOs.Configuration;
using ECommerceAPI.Web.Models;
using ECommerceAPI.WebHelper;
using ECommerceAPI.WebHelper.WebDTO;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerceAPI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApiHelper _apiHelper;

        public HomeController(ILogger<HomeController> logger, IApiHelper apiHelper)
        {
            _logger = logger;
            _apiHelper = apiHelper;
        }

        public IActionResult Index()
        {
            var response = _apiHelper.GetObjectResponseFromApi<List<Menu>>(RestSharp.Method.Get, "ApplicationServices/GetAuthorizeDefinitionEndpoints", null);

            //_apiHelper.GetObjectResponseFromApi<string>(RestSharp.Method.Get, "Login/SignUp", null); return View();
            return View(response);
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