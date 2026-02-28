using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Accessory : Product
    {
        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        public Accessory()
        {
        }

        public Accessory(string name, decimal price, int quantity, string category)
            : base(name, price, quantity)
        {
            Category = category;
        }

        public override string GetInfo()
        {
            return $"Accessory: {Name}, Category: {Category}, Price: {Price} lv, Quantity: {Quantity}";
        }
    }
}
