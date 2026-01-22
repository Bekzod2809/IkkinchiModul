using dars5.Models;

namespace dars5.Services;

public class CountryService : ICountryService
{
    List<Country> Countries;
    public CountryService()
    {
        Countries = new List<Country>();
    }
    public Guid AddCountry(Country Country)
    {
        Country.CountryId = Guid.NewGuid();
        Countries.Add(Country);
        return Country.CountryId;
    }

    public bool DeleteCountry(Guid CountryId)
    {
        foreach (var country in Countries)
        {
            if (country.CountryId == CountryId)
            {
                Countries.Remove(country);
                return true;

            }
        }
        return false;
    }

    public List<Country> GetAllCountries()
    {
        return Countries;
    }

    public Country? GetCountryById(Guid CountryId)
    {
        foreach (var country in Countries)
        {
            if (country.CountryId == CountryId)
            {
                return country;
            }
        }
        return null;
    }

    public bool UpdateCountry(Country NewCountry)
    {
        foreach (var country in Countries)
        {
            if (country.CountryId == NewCountry.CountryId)
            {
                country.Name = NewCountry.Name;
                country.Square = NewCountry.Square;
                country.Population = NewCountry.Population;
            }
            return true;
        }
        return false;
    }
}
