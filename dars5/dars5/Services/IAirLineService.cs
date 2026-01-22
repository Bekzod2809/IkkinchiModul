using dars5.Models;

namespace dars5.Services
{
    public interface IAirLineService
    {
        public Guid AddAirLine(AirLine airLine);
        public bool UpdateAirLine(AirLine airLine);
        public bool DeleteAirLine(Guid airLineId);
        public AirLine? GetAirLineById(Guid airLineId);
        public List<AirLine> GetAllAirLine();
    }
}
