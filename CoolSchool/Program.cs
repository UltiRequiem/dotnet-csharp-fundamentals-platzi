﻿using CoreSchool.Entities;

var school = new School("Platzi");

Console.WriteLine(school);

Course[] courses = { new Course("Python") };

school.AddCourses(courses);

school.ShowCourses();
