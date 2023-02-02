using DJ_WebDesignCore.Entites;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTO
{
    public class LAContext : DbContext
    {
        // Employee
        public DbSet<EmployeeLA> employees { get; set; }
        public DbSet<EmployeeRole> employeeRoles { get; set; }


        // Properties
        public DbSet<Address> addressEmployees { get; set; }

        public DbSet<Gender> genders { get; set; }
        // Student
        public DbSet<Student> students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Setting.connectServerUrl());
        }
    }
}
