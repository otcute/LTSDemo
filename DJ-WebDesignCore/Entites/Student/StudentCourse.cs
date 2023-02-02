using System;
using DJ_WebDesignCore.Entites.Courses;

namespace DJ_WebDesignCore.Entites.Employee
{
	public class EmployeeCourse
	{
	public int EmployeeCourseId { get; set; }
	public EmployeeLA? EmployeeId { get; set; }
	public CourseLA? CourseLAId { get; set; }
		public DateTime? OpenCourse { get; set; }
		public DateTime? CloseCourse { get; set; }

	}
}

