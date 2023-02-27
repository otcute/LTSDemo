using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IReserveCRUD
    {
        ReserveGetDTO getReserve(int? studentLAId);
    }
}
