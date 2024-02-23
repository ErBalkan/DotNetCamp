using Entities.Concrete;

namespace DataAccess.Abstract;
public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Delete(int courseId);
}