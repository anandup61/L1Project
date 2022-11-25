using SForms.DbClass;
using SForms.Models;

namespace SForms.Reposetry
{
    public class CityService : ICity
    {
        private readonly AppDbClass appDbClass;
        public CityService(AppDbClass appDbClass)
        {
            this.appDbClass = appDbClass;
        }

        public void AddCity(City cities)
        {
            try
            {
                if (cities != null)
                {
                    appDbClass.cities.Add(cities);
                    appDbClass.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        public List<City> GetCities()
        {
            try
            {

                var rs = appDbClass.cities.ToList();
                return rs;
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }
    }
}
