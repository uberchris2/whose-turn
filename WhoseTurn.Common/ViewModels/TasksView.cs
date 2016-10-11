using System.Collections.Generic;
using WhoseTurn.Common.Models;

namespace WhoseTurn.Common.ViewModels
{
    public class TasksView
    {
        public IEnumerable<Task> MyTasks { get; set; }
        public IEnumerable<Person> OtherPeople { get; set; }
    }
}