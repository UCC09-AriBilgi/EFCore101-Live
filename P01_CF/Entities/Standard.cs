namespace P01_CF.Entities
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }
        // Relational Definitions
        public ICollection<Student> Students { get; set; }
    }
}
