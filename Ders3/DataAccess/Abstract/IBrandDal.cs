using Entities.Concrete;

namespace DataAccess.Abstract;
public interface IBrandDal
{
    void Add(Brand brand);
    List<Brand> GetAll();
}