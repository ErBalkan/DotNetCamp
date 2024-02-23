using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;
public class CourseDal : ICourseDal
{
    private readonly List<Course> _courses = [
        new Course{Id=1,CategoryId=1,CompletionRate=0,InstructorName="Engin Demiroğ",Name="C# Yazılım geliştirici yetiştirme kursu"}
    ];
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(int courseId)
    {
        foreach (Course course in _courses)
        {
            if(course.Id == courseId){
                _courses.Remove(course);
            }
        }
    }

    public List<Course> GetAll()
    {
        return _courses;
    }
}