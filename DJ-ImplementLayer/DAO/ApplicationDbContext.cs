using System;
using DJ_LAServices.DAO;
using Microsoft.EntityFrameworkCore;

namespace DJ_ImplementLayer.DAO
{
    public class ApplicationDbContext : LAContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Setting.connectServerUrl());
            optionsBuilder.UseSqlServer(Setting.connectServerUrlMacOS());
        }
    }
}

