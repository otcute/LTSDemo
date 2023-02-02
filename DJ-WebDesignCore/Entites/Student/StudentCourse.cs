using System;
using System.ComponentModel.DataAnnotations.Schema;
using DJ_WebDesignCore.Entites.Courses;

namespace DJ_WebDesignCore.Entites.Employee
{
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }
        [ForeignKey("EmployeeId")]
        public EmployeeLA? Employee { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("CourseLAId")]
        public CourseLA? CourseLA { get; set; }
        public int? CourseLAId { get; set; }
        public DateTime? OpenCourse { get; set; }
        public DateTime? CloseCourse { get; set; }
    }
}

