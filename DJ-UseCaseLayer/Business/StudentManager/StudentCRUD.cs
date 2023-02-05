using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentCRUD : BaseDB, IStudentCRUD
    {
        public StudentFindByIdDTO findStudentById(int? studentId)
        {
            StudentFindByIdDTO res= new StudentFindByIdDTO();
            StudentLA data;
            if (studentId == null)
            {
                res.Status = DJ_WebDesignCore.Enums.StudentManagerEnums.StudentReadEnums.NULLID;
                res.ShortDetail = "Không nhận được id cần tìm";
                return res;
            }
            data = _context.studentLAs.Find(studentId);
            if (data == null)
            {
                res.Status = DJ_WebDesignCore.Enums.StudentManagerEnums.StudentReadEnums.NOTFOUND;
                res.ShortDetail = "Không tồn tại học viên có id là: " + studentId;
                return res;
            }
            res.Status = DJ_WebDesignCore.Enums.StudentManagerEnums.StudentReadEnums.FOUND;
            res.StudentLA = data;
            res.ShortDetail = "Tìm thấy!";
            return res;

        }

        StudentCreateDTO IStudentCRUD.createStudent(StudentLA newData)
        {
            StudentCreateDTO res = new StudentCreateDTO();
          
            
            res.Status = DJ_WebDesignCore.Enums.StudentManagerEnums.StudentCreateEnums.SUCCESSFULLY;
            res.ShortDetail = "Thêm học viên thành công!";
           _context.studentLAs.Add(newData);
            _context.SaveChanges();
            return res;
        }

        StudentDeleteDTO IStudentCRUD.deleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        StudentUpdateDTO IStudentCRUD.updateStudent(StudentLA newData)
        {
            throw new NotImplementedException();
        }
    }
}
