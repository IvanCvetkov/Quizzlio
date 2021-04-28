using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Text;

namespace Programming_Quizes.Database
{
    class QuizContext : DbContext
    {
        public DbSet<BtnToDb> Buttons { get; set; }

        public QuizContext()
        {
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "btn.db3");

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
