using ProjectBilling.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBilling.DataService
{
    public interface IDataService
    {
        IList<Project> GetProjects();
    }
    public class DataService : IDataService
    {
        public IList<Project> GetProjects()
        {
            List<Project> projects = new List<Project>()
            {
                new Project()
                {
                    ID = 1,
                    Name = "Halloway",
                    Estimate = 500
                },
                new Project()
                {
                    ID = 2,
                    Name = "Jones",
                    Estimate = 1500
                }
            };

            return projects;
        }
    }
}
