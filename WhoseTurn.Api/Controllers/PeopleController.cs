using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using WhoseTurn.Common.Models;
using WhoseTurn.Common.Services;

namespace WhoseTurn.Api.Controllers
{
    public class PeopleController : ApiController
    {
        private readonly PeopleService _peopleService = new PeopleService();

        [ResponseType(typeof(IEnumerable<Person>))]
        public IHttpActionResult GetTasks(string group)
        {
            var people = _peopleService.GetPeople(group);
            return Ok(people);
        }
    }
}