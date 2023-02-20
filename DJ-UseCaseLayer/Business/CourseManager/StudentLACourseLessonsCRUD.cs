using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.CourseManagerEnums;

namespace DJ_UseCaseLayer.Business.CourseManager
{
    public class StudentLACourseLessonsCRUD : BaseDB, IStudentLACourseLessonsCRUD
    {
        StudentLACourseLessonsCreateDTO IStudentLACourseLessonsCRUD.createStudentLACourseLessons(StudentLACourseLesson newData)
        {
            StudentLACourseLessonsCreateDTO res = new StudentLACourseLessonsCreateDTO();
            if (newData.StudentLAId == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được id học sinh";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(newData.StudentLAId);
            if (studentLA == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại student có id là {newData.StudentLAId}";
                return res;
            }

            if (newData.CourseLessonId == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được course lesson id";
                return res;
            }
            CourseLesson courseLesson = _context.courseLessons.Find(newData.CourseLessonId);
            if (courseLesson == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại course lesson có id là {newData.CourseLessonId}";
                return res;
            }

            if (newData.Score > 10 || newData.Score < 0)
            {
                res.Status = StudentLACourseLessonsCreateEnums.FAILED;
                res.ShortDetail = $"Điểm không chính xác";
                return res;
            }

            if (newData.EmployeeLAComfirmId == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được employee id";
                return res;
            }
            EmployeeLA employeeLA = _context.employeeLA.Find(newData.EmployeeLAComfirmId);
            if (employeeLA == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại employee có id là {newData.EmployeeLAComfirmId}";
                return res;
            }

            _context.studentLACourseLessons.Add(newData);
            _context.SaveChanges();

            res.Data = newData;
            res.Status = StudentLACourseLessonsCreateEnums.SUCCESSFULLY;
            res.ShortDetail = "Thêm thành công!";
            return res;
        }
    }
}
