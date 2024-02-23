using Entities.Abstract;

namespace Entities.Concrete;
public class Instructor : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}