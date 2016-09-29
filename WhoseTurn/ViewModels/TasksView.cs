using System.Collections.Generic;
using WhoseTurn.Models;

namespace WhoseTurn.ViewModels
{
    public class TasksView
    {
        public IEnumerable<Task> MyTasks { get; set; }
        public IEnumerable<Person> OtherPeople { get; set; }
    }
}