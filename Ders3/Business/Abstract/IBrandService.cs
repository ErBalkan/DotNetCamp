using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concrete;

namespace Business.Abstract;
public interface IBrandService
{
    CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest);
    List<GetAllBrandResponse> GetAll();
    
}

// Responses and Requests