namespace CoreSchool.Entities
{
    public class Course
    {
        public string id { get; private set; }
        public string name { get; private set; }


        public Course(string courseName)
        {
            name = courseName;
            id = Guid.NewGuid().ToString();
        }
    }

}
