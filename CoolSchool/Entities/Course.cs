namespace CoolSchool.Entities;

public class Course
{
    public string Id { get; }

    public string Name { get; }

    public Course(string courseName)
    {
        Name = courseName;
        Id = Guid.NewGuid().ToString();
    }
}
