using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;
public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int courseId)
    {
        _courseDal.Delete(courseId);
    }

    public void GetAll()
    {
        var courses = _courseDal.GetAll();
        courses.ForEach(course => {
            System.Console.WriteLine(course.Name);
        });
    }
}