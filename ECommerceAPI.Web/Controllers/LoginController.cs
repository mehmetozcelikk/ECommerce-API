using ECommerce.Application.DTOs.User;
using ECommerceAPI.WebHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Web.Controllers;

public class LoginController : Controller
{
    public IWebHostEnvironment _hostingEnvironment;
    private readonly IApiHelper _api;

    public LoginController(IWebHostEnvironment hostingEnvironment,  IApiHelper api)
    {
        _hostingEnvironment = hostingEnvironment;
        _api = api;
    }

    [AllowAnonymous]
    public IActionResult Register()
    {
        return View();
    }

    [AllowAnonymous]
    public IActionResult Login()
    {
        return View();
    }

    //[AllowAnonymous]
    //[HttpPost]
    //public IActionResult Register(CreateUser applicationUserDTO)
    //{

    //    var response = _api.GetObjectResponseFromApi<ApplicationUserDTO>(RestSharp.Method.POST, "Login/SignUp", applicationUserDTO);

    //    if (response.Success)
    //    {
    //        return Json(response);
    //    }
    //    else if (response.Success == false)
    //    {
    //        return Json(response);
    //    }
    //    return Json(response);


    //}
    //[AllowAnonymous]
    //[HttpPost]
    //public IActionResult Login(ApplicationUserDTO model)
    //{
    //    ResultDTO<ApplicationUserDTO> response = _userManager.SignIn(this.HttpContext, model);

    //    return Json(response);
    //}
}
