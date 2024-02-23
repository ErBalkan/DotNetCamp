using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;
public class InstructorDal : IInstructorDal
{
    private readonly List<Instructor> _ınstructors = [
        new Instructor{Id=1,Name="Engin"}
    ];
    public void Add(Instructor instructor)
    {
        _ınstructors.Add(instructor);
    }

    public void Delete(int instructorId)
    {
        foreach (Instructor instructor in _ınstructors)
        {
            if(instructor.Id == instructorId){
                _ınstructors.Remove(instructor);
            }
        }
    }

    public List<Instructor> GetAll()
    {
        return _ınstructors;
    }
}