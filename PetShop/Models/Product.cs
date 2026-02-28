using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{

    public class Product
    {
        [Key]
        public string Id { get; set; } 

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be positive")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual string GetInfo()
        {
            return $"Product: {Name}, Price: {Price} lv, Quantity: {Quantity}";
        }
    }
}
