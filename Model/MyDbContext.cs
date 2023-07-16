﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS2.Model
{
    public class MyDbContext : DbContext
    {
        public readonly string _path = @"D:\UOR documents\semester3_22nd\data structure & algorithms\codes\POS2\POS2\DB\MyNewDatabase.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_path}");
        }

        public DbSet<user> users { get; set; }
        public DbSet<menuitem> menuitems { get; set; }

    }
}
