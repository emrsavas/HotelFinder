﻿using HotelFinder.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class  HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-NUIFV6S\\SQLEXPRESS; Database=HotelDb;uid=DESKTOP-NUIFV6S\\emres;");
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
