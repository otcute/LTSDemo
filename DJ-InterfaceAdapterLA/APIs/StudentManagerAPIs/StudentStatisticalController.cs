using DJ_UseCaseLayer.Business.StudentManager;
using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs
{

    public class StudentStatisticalController : BaseAPI
    {
        private readonly IStudentStatistical _studentStatistical;

        public StudentStatisticalController()
        {
            _studentStatistical = new StudentStatistical();
        }
        [HttpGet("getListStudentLA/paging")]
        public ActionResult<StudentLAPagingDTO> getListStudentLA([FromQuery] int page)
        {
            return Ok(_studentStatistical.getListStudentLA(page));
        }
        [HttpGet("getListStatisticsStudyTime/paging")]
        public ActionResult<StatisticsStudyTimePagingDTO> getListStatisticsStudyTime([FromQuery] int page)
        {
            return Ok(_studentStatistical.getListStatisticsStudyTime(page));
        }
    }
}
