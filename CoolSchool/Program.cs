using CoolSchool.Entities;
using static System.Console;

var school = new School("Platzi");

WriteLine(school);

var courses = new[] { new Course("Python"), new Course("JavaScript") };

school.AddCourses(courses);

school.ShowCourses();
