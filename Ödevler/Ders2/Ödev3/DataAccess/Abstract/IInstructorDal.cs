using Entities.Concrete;

namespace DataAccess.Abstract;
public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Delete(int instructorId);
}