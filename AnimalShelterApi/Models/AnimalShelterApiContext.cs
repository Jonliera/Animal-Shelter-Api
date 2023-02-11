using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext>options) : base (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Spencer", Type = "Dog", Age = 2, Friendly = true, Sex = "Male"},
            new Animal { AnimalId = 2, Name = "Max",Type = "Dog", Age = 1, Friendly = false, Sex = "Male"},
            new Animal { AnimalId = 3, Name = "Marlowe", Type = "Dog", Age = 4, Friendly = true, Sex = "Female"},
            new Animal { AnimalId = 4, Name = "Bubba", Type = "Dog", Age = 5, Friendly = false, Sex = "Male"},
            new Animal { AnimalId = 5, Name = "Charlie", Type = "Dog", Age = 3, Friendly = true, Sex = "Male"},
            new Animal { AnimalId = 6, Name = "Sammy", Type = "Cat", Age = 7, Friendly = true, Sex = "Male"},
            new Animal { AnimalId = 7, Name = "Mango", Type = "Cat", Age = 9, Friendly = false, Sex = "Female"},
            new Animal { AnimalId = 8, Name = "Jewel", Type = "Cat", Age = 3, Friendly = true, Sex = "Female"},
            new Animal { AnimalId = 9, Name = "Bobby", Type = "Cat", Age = 7, Friendly = true, Sex = "Male"}
          );
        }
    }
  }
