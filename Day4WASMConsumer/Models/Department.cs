namespace Day4WASMConsumer.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Manager { get; set; }
        public int? Student { get; set; }
    }
}
