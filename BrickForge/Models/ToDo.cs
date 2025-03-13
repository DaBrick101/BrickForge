namespace BrickForge.Models
{
    public class ToDo
    {

        public int Id { get; set; }
        public string Task { get; set; } = string.Empty;
        public bool isCompleted { get; set; }
        public int XP { get; set; }
    }
}
