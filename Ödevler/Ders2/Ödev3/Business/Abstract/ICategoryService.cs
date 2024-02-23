using Entities.Concrete;

namespace Business.Abstract;
public interface ICategoryService
{
    void Add(Category category);
    void Delete(int categoryId);
    List<Category> GetAll();
}