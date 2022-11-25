using SForms.Models;

namespace SForms.Reposetry
{
    public interface IRegistration
    {
        List<Registration> GetRegistered();
        void Addone(Registration rr);
        Registration GetRegistration(int id);
        Registration DeletePerson(int id);
        void UpdateData(Registration Upd);
        Registration GetById(int id);
        List<RegistrationDetails> GetRegisteredList();
    }
}
