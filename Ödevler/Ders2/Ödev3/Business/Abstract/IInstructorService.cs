using Entities.Concrete;

namespace Business.Abstract;
public interface IInstructorService
{
    void Add(Instructor instructor);
    void Delete(int instructorId);
    List<Instructor> GetAll();
}