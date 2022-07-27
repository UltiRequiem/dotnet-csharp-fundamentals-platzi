namespace CoolSchool.Entities;

public class Course
{
    public string Id { get; private set; }
    public string Name { get; private set; }


    public Course(string courseName)
    {
        Name = courseName;
        Id = Guid.NewGuid().ToString();
    }
}
