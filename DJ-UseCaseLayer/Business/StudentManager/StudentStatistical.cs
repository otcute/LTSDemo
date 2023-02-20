using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using DJ_WebDesignCore.Enums.StudentActiveManagerEnums;
using Microsoft.EntityFrameworkCore;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentStatistical : BaseDB, IStudentStatistical
    {
        StudentLAPagingDTO IStudentStatistical.getListStudentLA(int page)
        {
            StudentLAPagingDTO resultData = new StudentLAPagingDTO();
            List<StudentLADTO> data = new List<StudentLADTO>();
            var listPage = _context.studentLAs.Include(x => x.studentCourses).OrderBy(x => x.CreateAccountDatetime).Skip((page - 1) * 10).Take(10).ToList();
            listPage.ForEach(x =>
            {
                StudentLADTO studentLa = new StudentLADTO();
                studentLa.StudentLAId = x.Id;
                studentLa.StudentLAName = x.StudentLAName;
                studentLa.StudentLASdt = x.StudentLASdt;
                studentLa.StudentCourses = x.studentCourses;
                if (x.StudentStatusId == 1 || x.StudentStatusId == 2)
                {
                    studentLa.IsActive = ActiveStatus.ACTIVE;
                }
                else
                {
                    studentLa.IsActive = ActiveStatus.UNACTIVE;
                }

                var currentEmployee = _context.studentEmployees.Where(y => y.StudentLAId == x.Id).OrderByDescending(y => y.SortNumber).Include(y => y.EmployeeLA).FirstOrDefault().EmployeeLA;
                studentLa.EmployeeLAId = currentEmployee.Id;
                studentLa.EmployeeLAName = currentEmployee.EmployeeLAName;
                data.Add(studentLa);
            });
            resultData.Status = 1;
            resultData.Data = data;
            resultData.Mes = "Lấy dữ liệu thành công";
            return resultData;
        }

        StatisticsStudyTimePagingDTO IStudentStatistical.getListStatisticsStudyTime(int page)
        {
            StatisticsStudyTimePagingDTO res = new StatisticsStudyTimePagingDTO();
            List<StatisticsStudyTimeDTO> data = new List<StatisticsStudyTimeDTO>();
            var listPages = _context.studentLAs.Include(x => x.studentCourses).OrderBy(x => x.CreateAccountDatetime).Skip((page - 1) * 10).Take(10).ToList();
            listPages.ForEach(x =>
            {
                StatisticsStudyTimeDTO item = new StatisticsStudyTimeDTO();
                item.StudentLAId = x.Id;
                item.StudentLAName = x.StudentLAName;
                item.StudentCourses = x.studentCourses;
                if (x.StudentStatusId == 1 || x.StudentStatusId == 2)
                {
                    item.IsActive = ActiveStatus.ACTIVE;
                }
                else
                {
                    item.IsActive = ActiveStatus.UNACTIVE;
                }
                item.HolidayTotal = x.HolidayTotal;
                item.UnactiveTotal = x.UnactiveTotal;
                item.ReserveTotal = x.ReserveTotal;
                data.Add(item);
            });
            res.Status = 1;
            res.Data = data;
            res.Mes = "Lấy dữ liệu thành công!";
            return res;
        }
    }
}
