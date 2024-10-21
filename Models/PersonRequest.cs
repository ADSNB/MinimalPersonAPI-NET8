namespace Person.Models
{
    public record PersonRequest(string Name);

    public class PersonRequest2
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

}
