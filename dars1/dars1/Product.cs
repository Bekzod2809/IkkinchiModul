namespace dars1;

public class Product
{
    public string name { get; set; }
    public int price { get; set; }
    public Guid productId { get; set; }
    public DateTime period { get; set; }
    public DateTime endperiod { get; set; }

    override public string ToString()
    {
        return $" ProductId: {productId}\n Product: {name}\n Price: {price}\n Period: {period}\n EndPeriod: {endperiod}";
    }
}
