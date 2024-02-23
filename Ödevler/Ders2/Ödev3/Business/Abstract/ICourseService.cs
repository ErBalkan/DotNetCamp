using Entities.Concrete;

namespace Business.Abstract;
public interface ICourseService
{
    void Add(Course course);
    void Delete(int courseId);
    void GetAll();
}