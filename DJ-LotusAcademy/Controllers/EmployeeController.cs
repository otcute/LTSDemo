using DJ_ImplementLayer.Business.StudentManager;
using DJ_ImplementLayer.DAO;
using DJ_LAServices.Business.StudentManager;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.AspNetCore.Mvc;

namespace DJ_LotusAcademy.Controllers
{
    [ApiController]
    [Route("api/employee/")]
    public class EmployeeController : ControllerBase
    {
        IStudentManager _studentManager;
        public EmployeeController()
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
