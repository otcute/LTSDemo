using System;
using System.ComponentModel.DataAnnotations.Schema;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_WebDesignCore.Entites.Employee
{
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }
        [ForeignKey("StudentLAId")]
        public StudentLA? StudentLA { get; set; }
        public int? StudentLAId { get; set; }
        [ForeignKey("CourseLAId")]
        public CourseLA? CourseLA { get; set; }
        public int? CourseLAId { get; set; }
        public DateTime? OpenCourse { get; set; }
        public DateTime? CloseCourse { get; set; }
    }
}

