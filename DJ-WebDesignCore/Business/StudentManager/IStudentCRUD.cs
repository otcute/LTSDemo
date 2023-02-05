using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.StudentManager
{
    public interface IStudentCRUD
    {
        StudentCreateDTO createStudent(StudentLA newData);
        StudentDeleteDTO deleteStudent(int studentId);
        StudentUpdateDTO updateStudent(StudentLA newData);
    }
}
