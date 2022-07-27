using CoreSchool.Entities;

var school = new School("Platzi");

Console.WriteLine(school);

var courses = new Course[] { new Course("Python") };

school.AddCourses(courses);

school.ShowCourses();
