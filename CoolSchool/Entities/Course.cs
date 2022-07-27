namespace CoreSchool.Entities
{
    public class Course
    {
        public int id;
        public string name;

        public Course(int courseId, string courseName) => (id, name) = (courseId, courseName);
    }

}
