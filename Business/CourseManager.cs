using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    public Course[] courses = new Course[3];

    public CourseManager()
    {
        Course course1 = new Course()
        {
            Id = 1,
            Name = "A",
            Description = "A V00.01",
            Price = 15
        };

        Course course2 = new Course()
        {
            Id = 2,
            Name = "B",
            Description = "B V00.02",
            Price = 10
        };

        Course course3 = new Course()
        {
            Id = 3,
            Name = "C",
            Description = "C V00.03",
            Price = 20
        };

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
