using Intro.DataAccess.Abstract;
using Intro.Entities;

namespace Intro.DataAccess.Concrete;

public class EfCourseDal : ICourseDal
{
    List<Course> Courses;

    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "Javascript";
        course1.Description = "Expressjs vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 17 vs...";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12 vs...";
        course3.Price = 20;

        Courses = new List<Course>{course1,course2,course3};

    }
    public List<Course> GetAll(){
        // Burada DB işlemleri yapılır.
        return Courses;
    }

    public void Add(Course course){
        Courses.Add(course);
    }
}