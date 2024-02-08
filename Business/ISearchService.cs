using Models.Models;

namespace Business;

public interface ISearchService
{
    Task<List<Country>> GetCountriesByName(string name);
    Task<List<City>> GetCitiesByCountryId(int id);
}
