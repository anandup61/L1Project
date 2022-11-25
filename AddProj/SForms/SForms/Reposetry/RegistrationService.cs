using SForms.DbClass;
using SForms.Models;

namespace SForms.Reposetry
{
    public class RegistrationService : IRegistration
    {
        private readonly AppDbClass appDbClass;
        private readonly ICity city;
        private readonly IState state;
        public RegistrationService(ICity citii, IState state, AppDbClass appDbClass)
        {
            this.appDbClass = appDbClass;
            this.city = citii;
            this.state = state;
        }

        public void Addone(Registration rr)
        {
            try
            {
                appDbClass.registrations.Add(rr);
                appDbClass.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Registration DeletePerson(int id)
        {
            try
            {
                if(id != 0)
                {
                    var rem = appDbClass.registrations.FirstOrDefault(x => x.Id == id);
                    appDbClass.registrations.Remove(rem);
                    appDbClass.SaveChanges();
                    return rem;
                }
                throw new Exception("Id is not found");
            }
            catch
            {
                throw   new Exception("data not deleted");
            }
          
        }

        public Registration GetById(int id)
        {
           var gt=appDbClass.registrations.FirstOrDefault(x => x.Id == id);
            return gt;
        }

        public List<Registration> GetRegistered()
        {
            try
            {
                var rg = appDbClass.registrations.ToList();
                return rg;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }

        public List<RegistrationDetails> GetRegisteredList()
        {
            
           
            List<RegistrationDetails> list = new List<RegistrationDetails>();   
            foreach(var r in appDbClass.registrations)
            {
                var RegistrationDetails = new RegistrationDetails();
                RegistrationDetails.Id = r.Id;
                RegistrationDetails.Name = r.firstName + ' ' + r.lastName;
                RegistrationDetails.FatherName = r.fatherName;
                RegistrationDetails.MotherName = r.motherName;

                RegistrationDetails.Gender = r.gender;
                RegistrationDetails.Dob=r.dob;
                
                RegistrationDetails.CityName = city.GetCities().FirstOrDefault(x => x.id == r.city).name;
                RegistrationDetails.StateName = state.GetState().FirstOrDefault(x => x.id == r.state).stateName;
                RegistrationDetails.Address = city.GetCities().FirstOrDefault(x => x.id == r.city).name + ' ' + state.GetState().FirstOrDefault(x => x.id == r.state).stateName;
                RegistrationDetails.RegisterDate = r.createdDate;
                list.Add(RegistrationDetails);
            }
            return list;
        }

        public Registration GetRegistration(int id)
        {
           try
            {
                if(id == 0)
                {
                    throw new Exception("id is null");
                }
                var Gett = appDbClass.registrations.FirstOrDefault(x => x.Id == id);
                return Gett;
            }
            catch(Exception exe)
            {
               throw exe;
            }

           
        }

        public void UpdateData(Registration Upd)
        {

            var upd = appDbClass.registrations.FirstOrDefault(x => x.Id == Upd.Id);
            upd.city=Upd.city;
            upd.dob=Upd.dob;
            appDbClass.registrations.Update(upd);
            appDbClass.SaveChanges();

        }
    }
}
