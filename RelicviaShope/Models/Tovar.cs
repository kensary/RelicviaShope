namespace RelicviaShope.Models;

public class Tovar
{
    public static Tovar? ActiveTovar = null; // активный товар
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public List<ShopingCard> ShopingCards { get; set; } =[]; // корзина товара
    public override string ToString()
    {
        return $"{Name} - {Price}$";
    }
}
