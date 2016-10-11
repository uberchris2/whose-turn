using System.Collections.Generic;

namespace WhoseTurn.Common.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}