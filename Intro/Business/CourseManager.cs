using Intro.DataAccess.Abstract;
using Intro.Entities;

namespace Intro.Business;
public class CourseManager
{
    // DEPENDENCY INJECTİON
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public CourseManager()
    {

    }
    public List<Course> GetAll(){
        // Business rules
        return _courseDal.GetAll();
    }
}