using System;
using System.ComponentModel.DataAnnotations.Schema;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_WebDesignCore.Entites.Employee
{
    public class StudentCourse:BaseEntity
    {
        public StudentLA? StudentLA { get; set; }
        public CourseLA? CourseLA { get; set; }
        public DateTime? OpenCourse { get; set; }
        public DateTime? CloseCourse { get; set; }
    }
}

