namespace dars6.Dtos;

public class FoodGetDto
{
    public Guid FoodId { get; set; }
    public string Name { get; set; }
    public decimal price { get; set; }
    public string Description { get; set; }
    public double Calories { get; set; }
}
