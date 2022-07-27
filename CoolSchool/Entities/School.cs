namespace CoolSchool.Entities;

public class School
{
    private readonly string _name;
    private readonly SchoolTypes _type;
    private Course[]? _courses;

    public School(string schoolName, SchoolTypes schoolTypes = SchoolTypes.HighSchool) => (_name, _type) = (schoolName.ToUpper(), schoolTypes);

    public override string ToString() => $"{_name} - {_type}";

    public void AddCourses(Course[] schoolCourses) => _courses = schoolCourses;

    public void ShowCourses()
    {
        if (_courses == null)
        {
            throw new Exception("This school does not have any courses.");
        }

        Console.WriteLine();

        foreach (var course in _courses)
        {
            Console.WriteLine($"{course.Name} - {course.Id}");
        }

        Console.WriteLine();
    }
}
