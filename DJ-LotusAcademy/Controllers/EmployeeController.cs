using DJ_WebDesignCore.DTO;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.AspNetCore.Mvc;

namespace DJ_LotusAcademy.Controllers
{
    [ApiController]
    [Route("api/employee/")]
    public class EmployeeController : ControllerBase
    {
        private LAContext context =new LAContext();
       
        [HttpGet("get")]
        public ActionResult<Student> getAll()
        {
            return Ok(context.students.ToList());
        }
    }
}
