using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;

namespace DJ_WebDesignCore.Business.CourseManager
{
    public interface IStudentLACourseLessonsCRUD
    {
        StudentLACourseLessonsCreateDTO createStudentLACourseLessons(StudentLACourseLesson newData);

    }
}
