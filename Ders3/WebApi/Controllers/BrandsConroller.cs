using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsConroller : ControllerBase
{

    private readonly IBrandService _brandService;

    public BrandsConroller(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpPost]
    public IActionResult Add(CreatedBrandRequest createdBrandRequest){
        CreatedBrandResponse createdBrandResponse = _brandService.Add(createdBrandRequest);

        return Ok(createdBrandResponse);
    }

    [HttpGet]
    public IActionResult Get(){
        return Ok(_brandService.GetAll());
    }
}