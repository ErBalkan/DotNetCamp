using Entities.Abstract;

namespace Entities.Concrete;
public class Course : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public string InstructorName { get; set; }
    public int CompletionRate { get; set; }
}