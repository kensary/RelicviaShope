namespace RelicviaShope.Models;

public class User
{
    public static User? ActiveUser = null;
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Password { get; set; }
    public List<ShopingCard> ShopingCards { get; set; } = []; // корзина пользователя
}
