using Microsoft.EntityFrameworkCore;

using System.Reflection.Emit;

using TaxiPark.Models;

namespace TaxiPark.Classes
{
    public class MainContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Vodila> Vodilas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=192.168.221.12;database=BibaAndBoba;User ID=user05;Password=05;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer(@"Data Source=hnt8.ru;database=BibaAndBoba;User ID=sa;Password=_RasulkotV2;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Service>().HasData(
                new Service() { Id = 1, Name = "Базовый",},
                new Service() { Id = 2, Name = "Комфорт",},
                new Service() { Id = 3, Name = "Экспресс", },
                 new Service() { Id = 4, Name = "С детьми",}
                );
            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1, Color = "красный", IsSale = true, Model = "Lada", IdVodila =1, StateNum = "ываывп"},
                new Car() { Id = 2, Color = "синий", IsSale = true, Model = "Lada", IdVodila = 1, StateNum = "ыва" },
                new Car() { Id = 3, Color = "желтый", IsSale = true, Model = "Lada", IdVodila = 2, StateNum = "ппарпар" }
                );
            modelBuilder.Entity<Vodila>().HasData(
                new Vodila() {Id =1, Name = "Лешка", LastName = "Сено", Phone = "89997254343"},
                new Vodila() { Id = 2, Name = "Ишак", LastName = "Турбо", Phone = "89997254344" }
                );
            modelBuilder.Entity<Order>().HasData(
               new Order() { Id = 1, NameClient = "Иванов Иван Иванович", PhoneClient  = "89997254347" , From = "from", Price = 1000 , To="To", IdCar = 1},
               new Order() { Id = 2, NameClient = "Иванов Иван Иванович", PhoneClient = "89997254347", From = "from", Price = 1000, To = "To", IdCar = 2 },
               new Order() { Id = 3, NameClient = "Иванов Иван Иванович", PhoneClient = "89997254347", From = "from", Price = 1000, To = "To", IdCar = 3 }
               );

        }

    }
}
