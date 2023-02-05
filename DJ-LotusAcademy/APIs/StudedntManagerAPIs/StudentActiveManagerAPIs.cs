using DJ_ImplementLayer.Business.StudentManager;
using DJ_ImplementLayer.DAO;
using DJ_LAServices.Business.StudentManager;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.AspNetCore.Mvc;

namespace DJ_LotusAcademy.APIs.StudedntManagerAPIs
{
    [ApiController]
    [Route("api/employee/")]
    public class StudentActiveManagerAPIs : ControllerBase
    {
        IStudentManager _studentManager;
        public StudentActiveManagerAPIs()
        {
            _studentManager = new StudentManager(new ApplicationDbContext());
        }

        [HttpPost("createstudent")]
        public ActionResult<StudentLA> createStudent([FromBody] StudentLA newData)
        {
            return Ok(_studentManager.createStudent(newData));
        }
    }
}
