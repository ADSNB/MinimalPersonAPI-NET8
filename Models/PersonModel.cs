using System.ComponentModel.DataAnnotations;

namespace Person.Models
{
    public class PersonModel
    {
        public PersonModel(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            IsActive = true;
        }

        [Key]
        public Guid Id { get; init; }
        public string? Name { get; private set; }
        public bool IsActive { get; set; }

        public void ChangeName(string name) => Name = name;

        public void SetIsActive(bool isActive) => IsActive = isActive;
    }
}
