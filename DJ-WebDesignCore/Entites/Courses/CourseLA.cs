using DJ_WebDesignCore.Entites.Properties;
using System;
namespace DJ_WebDesignCore.Entites.Courses
{
	public class CourseLA : BaseEntity
    {
		public string? CourseLACode { get; set; }
		public string? CourseLAName { get; set; }
		public double? CourseLAPrice { get; set; }
		public int? CourseStatusId { get;set; }
		public CourseStatus? CourseStatus { get; set;}
		
	}
}

