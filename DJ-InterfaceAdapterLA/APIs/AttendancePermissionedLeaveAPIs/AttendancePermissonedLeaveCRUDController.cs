﻿using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.AttendancePermissionedLeaveAPIs
{
    public class AttendancePermissonedLeaveCRUDController : BaseAPI
    {
        public readonly IAttendancePermissonedLeaveCRUD _attendancePermissonedLeaveCRUD;
        public AttendancePermissonedLeaveCRUDController()
        {
            _attendancePermissonedLeaveCRUD = new AttendancePermissionedLeaveCRUD();
        }
        [HttpGet("AttendancePermissionedLeave")]
        public ActionResult<AttendancePermissionedLeaveGetDTO> getAttendancePermissionedLeave(int? studentId)
        {
            return Ok(_attendancePermissonedLeaveCRUD.getAttendancePermissonedLeave(studentId));
        }
    }
}
