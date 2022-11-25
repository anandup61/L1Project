using SForms.Models;
using SForms.DbClass;

namespace SForms.Reposetry
{
    public class StandardName : IStandard
    {
        private readonly AppDbClass appdb;
        public StandardName(AppDbClass dbClass)
        {
            this.appdb = dbClass;
        }
        public void AddStandard(Standard ss)
        {
          try
            {
                appdb.standards.Add(ss);
                appdb.SaveChanges();
            }
            catch
            {
                throw new Exception("Data not added");
            }
        }

        public List<Standard> GetStandard()
        {
          try
            {
                var std = appdb.standards.ToList();
                return std;
            }
            catch
            {
                throw new Exception("Problem in gwtting data");
            }
        }

        public void Update(Standard updatee)
        {
            var u=appdb.standards.FirstOrDefault(x=>x.id==updatee.id);
            appdb.standards.Update(updatee);
            u.standardName = updatee.standardName;
            appdb.SaveChanges();
        }
    }
}
