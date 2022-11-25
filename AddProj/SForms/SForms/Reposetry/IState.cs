using SForms.Models;

namespace SForms.Reposetry
{
    public interface IState
    {
        List<States> GetState();
        void AddState(States st);
    }
}
