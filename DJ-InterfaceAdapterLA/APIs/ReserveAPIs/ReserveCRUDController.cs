using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.ReserveAPIs
{
    public class ReserveCRUDController : BaseAPI
    {
        public readonly IReserveCRUD _getReserveCRUD;
        public ReserveCRUDController()
        {
            _getReserveCRUD = new ReserveCRUD();
        }
        [HttpGet("Reserve")]
        public ActionResult<ReserveGetDTO> getReserve(int? studentLAId)
        {
            return Ok(_getReserveCRUD.getReserve(studentLAId));
        }
    }
}
