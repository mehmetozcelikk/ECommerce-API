using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ECommerceAPI.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }
        public string GetCurrentUser()
        {
            string userJson = HttpContext.User.Claims.Where(s => s.Type == "UserInfo").FirstOrDefault().Value;
            string dto = JsonSerializer.Deserialize<string>(userJson);
            return dto;
        }
        public string GetToken()
        {
            string token = HttpContext.User.Claims.Where(s => s.Type == "Secret").FirstOrDefault().Value;
            return token;
        }
    }
}
