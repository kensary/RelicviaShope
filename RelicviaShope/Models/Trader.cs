namespace RelicviaShope.Models;

public class Trader: User
{
    public required string Inn { get; set; } // ИНН
    public List<Tovar> Tovar { get; set; } = []; // товары продавца

} 
