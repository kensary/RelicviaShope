using Microsoft.EntityFrameworkCore;
using RelicviaShope.Models;

namespace RelicviaShope;

public class DataBaseContext:DbContext
{
    public DbSet<User> Users { get; set; } // таблица пользователей
    public DbSet<Tovar> Tovars { get; set; } // таблица товаров
    public DbSet<ShopingCard> ShopingCards { get; set; } // таблица корзин
    public DbSet<Trader> Traders { get; set; } // таблица продавцов
    public DbSet<Admin> Admins { get; set; } // таблица администраторов
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RelicviaShope;Trusted_Connection=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .UseTptMappingStrategy(); // Используем TPT для наследования
        modelBuilder.Entity<Tovar>().HasData([
            new Tovar
            {   
                Id = 1001,
                Name = "Товар 1",
                Price = 1000,
                Description = "Описание товара 1"
            },
            new Tovar
            {
                Id = 19991,
                Name = "Товар 2",
                Price = 1000000,
                Description = "Описание товара 2"
            },
            ]);
    }
}
