using dars5.Models;

namespace dars5.Services;

public interface ICountryService
{
    public Guid AddCountry(Country Country);
    public bool UpdateCountry(Country Country);
    public bool DeleteCountry(Guid CountryId);
    public Country? GetCountryById(Guid CountryId);
    public List<Country> GetAllCountries();
}
