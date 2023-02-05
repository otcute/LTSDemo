using DJ_WebDesignCore.Business.EmployeeManager;
using DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs;
using DJ_WebDesignCore.Entites.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.Business.EmployeeManager
{
    public class EmployeeCRUD : IEmployeeCRUD
    {
        EmployeeCreateDTO IEmployeeCRUD.createEmployee(EmployeeLA newData)
        {
            return null;
        }

        EmployeeDeleteDTO IEmployeeCRUD.deleteEmployee(EmployeeLA newData)
        {
            throw new NotImplementedException();
        }

        EmployeeUpdateDTO IEmployeeCRUD.updateEmployee(EmployeeLA newData)
        {
            throw new NotImplementedException();
        }
    }
}
