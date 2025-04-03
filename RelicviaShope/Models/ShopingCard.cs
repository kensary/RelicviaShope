namespace RelicviaShope.Models;

public class ShopingCard
{
    public int Id { get; set; } // id корзины
    public required int UserId { get; set; } // id пользователя
    public User User { get; set; } = null!; // пользователь
    public required int TovarId { get; set; } // id товара
    public Tovar Tovar { get; set; } = null!; // товар
    public int Quantity { get; set; } = 1; // количесвто товара
}
