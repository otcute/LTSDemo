using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentStatistical :BaseDB,IStudentStatistical
    {
        public StudentLAPagingDTO getListStudentLA(int page)
        {
            StudentLAPagingDTO resultData = new StudentLAPagingDTO();
            List<StudentLADTO> data= new List<StudentLADTO>();
            var listPage = _context.studentLAs.Include(x=>x.studentCourses).OrderBy(x => x.CreateAccountDatetime).Skip(page - 1).Take(10).ToList();
            listPage.ForEach(x =>
            {
            StudentLADTO studentLa = new StudentLADTO();
            studentLa.StudentLAId = x.Id;
            studentLa.StudentLAName = x.StudentLAName;
            studentLa.StudentLASdt = x.StudentLASdt;
            studentLa.StudentCourses = x.studentCourses;
            if (x.StudentStatusId == 1 || x.StudentStatusId == 2)
            {
                studentLa.IsActive = DJ_WebDesignCore.Enums.StudentActiveManagerEnums.ActiveStatus.ACTIVE;
            }
            studentLa.IsActive = DJ_WebDesignCore.Enums.StudentActiveManagerEnums.ActiveStatus.UNACTIVE;
                var t = _context.studentEmployees.Where(x => x.StudentLAId == x.StudentLAId).ToList();
                studentLa.EmployeeLAName =_context.studentEmployees.Include(x=>x.EmployeeLA).Where(x => x.StudentLAId == x.StudentLAId).OrderByDescending(x => x.SortNumber).FirstOrDefault().EmployeeLA.EmployeeLAName;
                data.Add(studentLa);
            });
            resultData.Status = 1;
            resultData.Data = data;
            resultData.Mes = "Lấy dữ liệu thành công";
            return resultData;
        }

        StatisticsStudyTimeDTO IStudentStatistical.getListStatisticsStudyTime()
        {
            return null;
        }

      
    }
}
