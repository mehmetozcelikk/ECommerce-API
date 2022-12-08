﻿using ECommerce.Application.Abstractions.Services.Configurations;
using ECommerce.Application.CustomAttributes;
using ECommerce.Application.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize(AuthenticationSchemes = "Admin")]
public class ApplicationServicesController : ControllerBase
{
    readonly IApplicationService _applicationService;

    public ApplicationServicesController(IApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    [HttpGet ("GetAuthorizeDefinitionEndpoints")]
    [AuthorizeDefinition(ActionType = ActionType.Reading, Definition = "Get Authorize Definition Endpoints", Menu = "Application Services")]
    public IActionResult GetAuthorizeDefinitionEndpoints()
    {
        var datas = _applicationService.GetAuthorizeDefinitionEndpoints(typeof(Program));
        return Ok(datas);
    }
}
