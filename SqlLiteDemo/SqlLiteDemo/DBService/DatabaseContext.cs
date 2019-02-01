using System.IO;
using Microsoft.EntityFrameworkCore;
using SqlLiteDemo.Model;
using Xamarin.Essentials;

namespace SqlLiteDemo.DBService
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DbSet<IBAPolygon> IbaPolygons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}", x => x.UseNetTopologySuite());
        }
    }
}