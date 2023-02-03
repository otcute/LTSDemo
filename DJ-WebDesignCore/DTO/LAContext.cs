using DJ_WebDesignCore.Entites;
using DJ_WebDesignCore.Entites.Courses;
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
        public DbSet<EmployeeLA> employeeLA { get; set; }
        public DbSet<EmployeeRole> employeeRoles { get; set; }


        // Properties
        public DbSet<Address> address { get; set; }

        public DbSet<Gender> genders { get; set; }
        // Student
        public DbSet<StudentLA> students { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }

        //Course
        public DbSet<CourseLA> courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Setting.connectServerUrl());
            optionsBuilder.UseSqlServer(Setting.connectServerUrlMacOS());
        }
    }
}
