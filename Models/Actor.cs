namespace ActorRepositoryLib2.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int BirthYear { get; set; }

        public string Country { get; set; } = string.Empty;

        
        public  List<string> Movies { get; set; } = new List<string>();

    }
}
