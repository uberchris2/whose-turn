using System.Collections.Generic;
using System.Linq;
using WhoseTurn.Common.Models;

namespace WhoseTurn.Common.Services
{
    public class PeopleService
    {
        protected readonly DbModel Db = new DbModel();

        public List<Person> GetPeople(string group)
        {
            return Db.People.Where(p => p.Group.Name == group).ToList();
        }
    }
}