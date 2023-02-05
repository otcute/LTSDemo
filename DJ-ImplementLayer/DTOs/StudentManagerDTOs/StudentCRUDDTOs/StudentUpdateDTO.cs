using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs
{
    public class StudentUpdateDTO
    {
        public StudentCreateEnums? Status { get; set; }
        public StudentLA? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
