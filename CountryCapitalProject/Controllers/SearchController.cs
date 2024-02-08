using Business;
using Microsoft.AspNetCore.Mvc;

namespace CountryCapitalProject.Controllers;

[Route("Search")]
public class SearchController : Controller
{
    private ISearchService _searchservice;
    public SearchController(ISearchService searchservice)
    {
        _searchservice = searchservice;
    }

    [HttpGet("GetCountriesByName/{name}")]
    public async Task<IActionResult> GetAll(string name)
    {
        var data = await _searchservice.GetCountriesByName(name);
        return Ok(data);
    }

    [HttpGet("GetCitiesByCountryId/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await _searchservice.GetCitiesByCountryId(id);
        return Ok(data);
    }
}
