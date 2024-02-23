using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;
public class InstructorManager : IInstructorService
{

    private readonly IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(int instructorId)
    {
        _instructorDal.Delete(instructorId);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }
}