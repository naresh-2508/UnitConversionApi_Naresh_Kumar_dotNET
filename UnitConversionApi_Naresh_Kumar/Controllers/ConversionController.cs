
using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services;

namespace UnitConversionApi.Controllers;

[ApiController]
[Route("api/conversions")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _service;
    public ConversionController(IConversionService service)=>_service=service;

    [HttpPost]
    public IActionResult Convert(ConversionRequest request)
        => Ok(_service.Convert(request));
}
