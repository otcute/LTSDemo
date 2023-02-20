using DJ_UseCaseLayer.Business.CourseManager;
using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentLACourseLessonsAPIs
{
    public class StudentLACourseLessonsCRUDController : BaseAPI
    {
        public readonly IStudentLACourseLessonsCRUD _studentLACourseLessonsCRUD;
        public StudentLACourseLessonsCRUDController()
        {
            _studentLACourseLessonsCRUD = new StudentLACourseLessonsCRUD();
        }

        [HttpPost("Themmoistudentlesson")]
        public ActionResult<StudentLACourseLessonsCreateDTO> createStudentLACourseLessons([FromBody] StudentLACourseLesson newData)
        {
            return Ok(_studentLACourseLessonsCRUD.createStudentLACourseLessons(newData));
        }
    }
}
