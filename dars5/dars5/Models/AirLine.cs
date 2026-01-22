namespace dars5.Models;

public class AirLine
{
    public Guid AirLineId { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public int FoundedYear { get; set; }
    public int FleetSize { get; set; }
}
