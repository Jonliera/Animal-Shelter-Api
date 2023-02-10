using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext>options)
        : base (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Spencer", Type = "Dog", Age = 2},
            new Animal { AnimalId = 2, Name = "Max",Type = "Dog", Age = 1},
            new Animal { AnimalId = 3, Name = "Marlowe", Type = "Dog", Age = 4},
            new Animal { AnimalId = 4, Name = "Bubba", Type = "Dog", Age = 5},
            new Animal { AnimalId = 5, Name = "Charlie", Type = "Dog", Age = 3},
            new Animal { AnimalId = 6, Name = "Sammy", Type = "Cat", Age = 7},
            new Animal { AnimalId = 7, Name = "Mango", Type = "Cat", Age = 9},
            new Animal { AnimalId = 8, Name = "Jewel", Type = "Cat", Age = 3},
            new Animal { AnimalId = 9, Name = "Bobby", Type = "Cat", Age = 7}
          );
        }
    }
  }
