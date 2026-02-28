using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Food : Product
    {
        [Required]
        [Display(Name = "Animal Type")]
        public string AnimalType { get; set; }

        public Food()
        {
        }

        public Food(string name, decimal price, int quantity, string animalType)
            : base(name, price, quantity)
        {
            AnimalType = animalType;
        }

        public override string GetInfo()
        {
            return $"Food: {Name}, For: {AnimalType}, Price: {Price} lv, Quantity: {Quantity}";
        }
    }
}
