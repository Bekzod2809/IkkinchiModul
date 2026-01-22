using dars5.Models;

namespace dars5.Services;

public class AirLineService : IAirLineService
{
    List<AirLine> AirLines;
    public AirLineService()
    {
        AirLines = new List<AirLine>();
    }
    public Guid AddAirLine(AirLine airLine)
    {
        airLine.AirLineId = Guid.NewGuid();
        AirLines.Add(airLine);
        return airLine.AirLineId;
    }

    public bool DeleteAirLine(Guid airLineId)
    {
        foreach (var airLine in AirLines)
        {
            if (airLine.AirLineId == airLineId)
            {
                AirLines.Remove(airLine);
                return true;
            }
        }
        return false;
    }

    public AirLine? GetAirLineById(Guid airLineId)
    {
        foreach (var airLine in AirLines)
        {
            if (airLine.AirLineId == airLineId)
            {
                return airLine;
            }
        }
        return null;
    }

    public List<AirLine> GetAllAirLine()
    {
        return AirLines;
    }

    public bool UpdateAirLine(AirLine newairLine)
    {
        foreach (var airLine in AirLines)
        {
            if (airLine.AirLineId == newairLine.AirLineId)
            {
                airLine.FleetSize = newairLine.FleetSize;
                airLine.Name = newairLine.Name;
                airLine.Country = newairLine.Country;
                airLine.FoundedYear = newairLine.FoundedYear;
                return true;
            }
        }
        return false;
    }
}
