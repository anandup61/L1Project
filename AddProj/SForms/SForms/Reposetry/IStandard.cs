using SForms.Models;

namespace SForms.Reposetry
{
    public interface IStandard
    {
        List<Standard> GetStandard();
        void AddStandard(Standard ss);
        void Update(Standard updatee);
    }
}
