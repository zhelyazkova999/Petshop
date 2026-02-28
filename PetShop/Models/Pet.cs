using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Pet
    {
        [Key]
        public string Id { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Species")]
        public string Species { get; set; }

        [Required]
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public Pet(string name, string species, int age, decimal price)
        {
            Name = name;
            Species = species;
            Age = age;
            Price = price;
        }

        public string GetInfo()
        {
            return $"Pet: {Name}, Breed: {Breed}, Species: {Species}, Age: {Age}, Price: {Price} eur.";
        }
    }
}
