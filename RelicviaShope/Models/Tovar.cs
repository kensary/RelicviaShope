namespace RelicviaShope.Models;

public class Tovar
{
    public static Tovar? ActiveTovar = null; // активный товар
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required int TraderId { get; set; } // id продавца
    public List<ShopingCard> ShopingCards { get; set; } =[]; // корзина товара
    public Trader Trader { get; set; } = null!;// продавец
    public override string ToString()
    {
        return $"{Name}||цена: {Price}$||id продавца: {TraderId}";
    }
}
