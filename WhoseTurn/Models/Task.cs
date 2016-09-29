namespace WhoseTurn.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TurnPersonId { get; set; }
        public Person TurnPerson { get; set; }
    }
}