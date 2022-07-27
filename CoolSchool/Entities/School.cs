namespace CoreSchool.Entities
{
    class School
    {
        public string name;
        public SchoolTypes type;
        public Course[]? courses;

        public School(string schoolName, SchoolTypes schoolTypes = SchoolTypes.HighSchool) => (name, type) = (schoolName.ToUpper(), schoolTypes);

        public override string ToString() => $"{name} - {type}";

        public void AddCourses(Course[] schoolCourses) => courses = schoolCourses;

        public void ShowCourses()
        {
            if (courses == null)
            {
                throw new Exception("This school does not have any courses.");
            }

            Console.WriteLine();

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.name} - {course.id}");
            }

            Console.WriteLine();
        }
    }

}
