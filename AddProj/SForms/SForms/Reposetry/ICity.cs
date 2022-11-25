using SForms.Models;

namespace SForms.Reposetry
{
    public interface ICity
    {
        List<City> GetCities();
        void AddCity(City cities);
    }
}
