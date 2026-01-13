namespace dars3.Models;

public class Phone
{
    public Guid PhoneId { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
}
