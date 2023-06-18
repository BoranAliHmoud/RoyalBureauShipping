using Microsoft.EntityFrameworkCore;
using RoyalBureauShipping.Models;
using System.Xml;

namespace RoyalBureauShipping.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
		}
		
		public DbSet<User> Users { get; set; }
        public DbSet<ShipModel> Ships { get; set; }
		 public DbSet<CargoShip> CargoShips { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure your entities and relationships here

			// Seed data

			modelBuilder.Entity<User>().HasData( 
				new User
				{
					Id=1,
					FirstName = "Admin",
					LastName = "Admin",
					Email = "RoyalBureauShipping@admin.com",
			  		Password = "123456789"
		     	}
			);
			 
			modelBuilder.Entity<CargoShip>().HasData(
				new CargoShip { Id=1,Name = "Bulk Carrier" },
				new CargoShip { Id = 2, Name = "Oil Tanker" },
				new CargoShip { Id = 3, Name = "Chemical Tanker" },
				new CargoShip { Id = 4, Name = " Gas Carrier" },
				new CargoShip { Id = 5, Name = "Cargo Ship other than any of the above" }
			// Add additional entities as needed
			);
		}
 	 
	}
}
// اي اضافه او تعديل لداتابيس بستخدم الجملتين هدول 
// add-migration MyFirstMigration
//Update-Database



// حذف اخر  Migration 
// قبل ما نعمل Update-Database
//Remove-Migration
