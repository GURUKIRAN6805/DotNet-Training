using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using CCA_API.Models;

namespace CCA_API.Controllers
{
    public class CountryController : ApiController
    {
        private static readonly List<Country> _countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "INDIA", Capital = "DELHI" },
            new Country { ID = 2, CountryName = "AUSTRLIA", Capital = "CANBERRA" },
            new Country { ID = 3, CountryName = "MEXICO", Capital = "MEXICO CITY"},
            new Country { ID = 4, CountryName = "GERMANY", Capital = "BERLIN"}
        };
        public IHttpActionResult GetAllCountries()
        {
            if (!_countries.Any())
            {
                return NotFound();
            }
            return Ok(_countries);
        }
        public IHttpActionResult GetCountryById(int id)
        {
            var country = _countries.SingleOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        public IHttpActionResult AddNewCountry(Country newCountry)
        {
            if (newCountry == null || string.IsNullOrWhiteSpace(newCountry.CountryName) || string.IsNullOrWhiteSpace(newCountry.Capital))
            {
                return BadRequest("Please provide valid country information.");
            }
            newCountry.ID = _countries.Any() ? _countries.Max(c => c.ID) + 1 : 1;
            _countries.Add(newCountry);
            return CreatedAtRoute("DefaultApi", new { id = newCountry.ID }, newCountry);
        }
        public IHttpActionResult PutCountry(int id, Country updatedCountry)
        {
            var country = _countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
        public IHttpActionResult DeleteCountry(int id)
        {
            var countryToRemove = _countries.SingleOrDefault(c => c.ID == id);
            if (countryToRemove == null)
            {
                return NotFound();
            }
            _countries.Remove(countryToRemove);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}