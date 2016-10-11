using System.Collections.Generic;

namespace WhoseTurn.Common.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Person> People { get; set; }
    }
}