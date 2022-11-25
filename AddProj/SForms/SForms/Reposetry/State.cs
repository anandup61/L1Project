using SForms.DbClass;
using SForms.Models;

namespace SForms.Reposetry
{
    public class State : IState
    {
        private readonly AppDbClass appDb;
        public State(AppDbClass appDb)
        {
            this.appDb = appDb;
        }

        public void AddState(States st)
        {
            try
            {
                appDb.states.Add(st);
                appDb.SaveChanges();
            }
            catch
            {
                throw new Exception("Data not added");
            }
        }
        List<States> IState.GetState()
        {
            try
            {
                var stat = appDb.states.ToList();
                return stat;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
