using CoreSchool.Entities;

var school = new School("Platzi");

Console.WriteLine(school);

Course[] courses = { new Course(34, "Python") };

school.AddCourses(courses);

school.ShowCourses();
