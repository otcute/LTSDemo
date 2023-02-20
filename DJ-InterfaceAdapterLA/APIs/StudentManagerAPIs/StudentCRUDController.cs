using DJ_UseCaseLayer.Business.StudentManager;
using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs
{
    public class StudentCRUDController : BaseAPI
    {
        private readonly IStudentCRUD _studentCRUD;

        public StudentCRUDController()
        {
            _studentCRUD = new StudentCRUD();
        }
        [HttpPost("StudentCRUD")]
        public ActionResult<StudentCreateDTO> createEmployee([FromBody] StudentLA newData)
        {
            return Ok(_studentCRUD.createStudent(newData));
        }
        [HttpGet("StudentCRUD/{studentId}")]
        public ActionResult<StudentFindByIdDTO> findStudentById(int? studentId)
        {
            return Ok(_studentCRUD.findStudentById(studentId));
        }
        [HttpDelete("StudentCRUD/{studentId}")]
        public ActionResult<StudentDeleteDTO> deleteStudent(int? studentId)
        {
            return Ok(_studentCRUD.deleteStudent(studentId));
        }
        [HttpPut("StudentCRUD")]
        public ActionResult<StudentUpdateDTO> updateStudent([FromBody] StudentLA studentLA)
        {
            return Ok(_studentCRUD.updateStudent(studentLA));
        }
    }
}
