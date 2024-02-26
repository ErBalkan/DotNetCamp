using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;
public class BrandManager : IBrandService
{

    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest)
    {
        // Business Rules

        // Mapping
        Brand brand = new();
        brand.Name = createdBrandRequest.Name;
        brand.CreatedDate = DateTime.Now;
        
        _brandDal.Add(brand);

        // Mapping
        CreatedBrandResponse createdBrandResponse = new();
        createdBrandResponse.Id = 4;
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.CreatedDate = brand.CreatedDate;

        return createdBrandResponse;

    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();
        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.CreatedDate = brand.CreatedDate;

            getAllBrandResponses.Add(getAllBrandResponse);
        }
        
        return getAllBrandResponses;

    }
}