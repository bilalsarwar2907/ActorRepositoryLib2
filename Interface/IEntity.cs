namespace ActorRepositoryLib2.Interface
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Country { get; set; }
        public List<string> Movies { get; set; }
    }
}
