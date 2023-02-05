using DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs;
using DJ_WebDesignCore.Entites.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.EmployeeManager
{
    public interface IEmployeeCRUD
    {
        EmployeeCreateDTO createEmployee(EmployeeLA newData);
        EmployeeUpdateDTO updateEmployee(EmployeeLA newData);
        EmployeeDeleteDTO deleteEmployee(EmployeeLA newData);
    }
}
