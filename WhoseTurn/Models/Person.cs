using System.Collections.Generic;

namespace WhoseTurn.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}