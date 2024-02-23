using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;
public class CategoryDal : ICategoryDal
{
    private readonly List<Category> _categories = [
        new Category{Id=1, Name="Programlama"},
        new Category{Id=2, Name="Web tasarım"},
    ];

    public void Add(Category category)
    {
        _categories.Add(category);
        System.Console.WriteLine($"{category.Name} eklendi.");
    }

    public void Delete(int categoryId)
    {
        foreach (Category category in _categories)
        {
            if(category.Id == categoryId){
                _categories.Remove(category);
                System.Console.WriteLine($"{category} silindi.");
            }
        }
    }

    public List<Category> GetAll()
    {
        return _categories;
    }
}