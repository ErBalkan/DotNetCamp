using Entities.Concrete;

namespace DataAccess.Abstract;
public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Delete(int categoryId);
}