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
        [HttpPost("themmoi")]
        public ActionResult<StudentCreateDTO> createEmployee([FromBody] StudentLA newData)
        {
            return Ok(_studentCRUD.createStudent(newData));
        }
        [HttpGet("timtheoid")]
        public ActionResult<StudentFindByIdDTO> findStudentById(int? studentId)
        {
           return Ok(_studentCRUD.findStudentById(studentId));
        }
    }
}
