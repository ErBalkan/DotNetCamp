using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int categoryId)
    {
        _categoryDal.Delete(categoryId);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }
}