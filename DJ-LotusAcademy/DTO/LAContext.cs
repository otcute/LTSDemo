﻿using DJ_WebDesignCore.Entites;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.EntityFrameworkCore;

namespace DJ_WebDesignCore.DTO
{
    public class LAContext 
    {
        // Employee
        public DbSet<EmployeeLA> employeeLA { get; }
        public DbSet<EmployeeRole> employeeRoles { get; set; }
        // Properties
        public DbSet<Address> address { get; set; }
        public DbSet<CourseStatus> courseStatuses { get; set; }
        public DbSet<EmployeeStatus> employeeStatuses { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<StudentStatus> studentStatuses { get; set; }
        // Student
        public DbSet<StudentLA> students { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        // Course
        public DbSet<CourseLA> courses { get; set; }
        // Business
        public DbSet<Holiday> holidays { get; set; }
        public DbSet<Reserve> reserves { get; set; }
        public DbSet<UnauthorizedAbsences> unauthorizedAbsences { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(Setting.connectServerUrl());
        //    //optionsBuilder.UseSqlServer(Setting.connectServerUrlMacOS());
        //}
    }
}
