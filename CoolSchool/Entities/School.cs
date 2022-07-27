namespace CoolSchool.Entities;
    internal class School
    {
        private string name;
        private SchoolTypes type;
        private Course[]? _courses;

        public School(string schoolName, SchoolTypes schoolTypes = SchoolTypes.HighSchool) => (name, type) = (schoolName.ToUpper(), schoolTypes);

        public override string ToString() => $"{name} - {type}";

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
