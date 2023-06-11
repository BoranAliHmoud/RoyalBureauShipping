using Microsoft.EntityFrameworkCore;
using RoyalBureauShipping.Models;

namespace Certificate.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        //public DbSet<Certificate> Certificate { get; set; }
       // public DbSet<ShipSafety> ShipSafety { get; set; } 
    }
}
// اي اضافه او تعديل لداتابيس بستخدم الجملتين هدول 
// add-migration MyFirstMigration
//Update-Database



// حذف اخر  Migration 
// قبل ما نعمل Update-Database
//Remove-Migration
