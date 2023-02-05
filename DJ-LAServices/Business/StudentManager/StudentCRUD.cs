using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_LAServices.Business.StudentManager
{
    public class StudentCRUD : BaseDB, IStudentCRUD
    {
        StudentCreateDTO IStudentCRUD.createStudent(StudentLA newData)
        {
           _context.Add(newData);
            _context.SaveChanges();
            return new StudentCreateDTO();
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
