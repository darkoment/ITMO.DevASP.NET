using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Course
/// </summary>
public class Course
{
    public Course()
    {

    }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public DateTime SemesterHour { get; set; }

    public virtual List<Group> Groups { get; set; }
    public virtual List <Lecturer> Lecturers { get; set;}
}