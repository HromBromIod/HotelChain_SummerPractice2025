using HotelChain.BusinessLogic.Services;
using HotelChain.Web.Models;
using HotelChain.Web.Models.DeleteHotel;
using HotelChain.Web.Models.CreateHotel;
using HotelChain.Web.Models.HotelInfo;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelChain.Web.Controllers;

[ApiController]
[Route("api/hotels")]
public class HotelsController(
    ILogger logger,
    IHotelsService hotelsService)
    : ControllerBase
{
    [HttpGet]
    [Route("info")]
    public async Task<IActionResult> HotelInfo([FromQuery] HotelInfoRequestDto request, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: {request}");

        var validationResult = request.Validate();
        if (!validationResult.IsValid)
        {
            logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: {validationResult.ErrorMessage}");
            return BadRequest(validationResult.ToError());
        }

        var response = await hotelsService.GetHotelInfoById(request.ToRequest(), cancellationToken);

        if (!response.Success)
        {
            logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: {response.ErrorMessage}");
            return BadRequest(response.ToError());
        }

        logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: Success by {request.Id}");
        return Ok(response.ToDto());
    }
    
    [HttpDelete]
    [Route("delete")]
    public async Task<IActionResult> DeleteHotel([FromQuery] DeleteHotelRequestDto request, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: {request}");

        var validationResult = request.Validate();
        if (!validationResult.IsValid)
        {
            logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: {validationResult.ErrorMessage}");
            return BadRequest(validationResult.ToError());
        }

        var response = await hotelsService.DeleteHotelById(request.ToRequest(), cancellationToken);

        if (!response.Success)
        {
            logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: {response.ErrorMessage}");
            return BadRequest(response.ToError());
        }

        logger.Information($"{nameof(HotelsController)}.{nameof(HotelInfo)}: Success by {request.Id}");
        return Ok(response.ToDto());
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateHotel([FromQuery] CreateHotelRequestDto request, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsController)}.{nameof(CreateHotel)}: {request}");
        
        var validationResult = request.Validate();
        if (!validationResult.IsValid)
        {
            logger.Information($"{nameof(HotelsController)}.{nameof(CreateHotel)}: {validationResult.ErrorMessage}");
            return BadRequest(validationResult.ToError());
        }

        var response = await hotelsService.CreateHotel(request.ToRequest(), cancellationToken);
        
        if (!response.Success)
        {
            logger.Information($"{nameof(HotelsController)}.{nameof(CreateHotel)}: {response.ErrorMessage}");
            return BadRequest(response.ToError());
        }

        logger.Information($"{nameof(HotelsController)}.{nameof(CreateHotel)}: Success create {response.Id}");
        return Ok(response.ToDto());
    }
}