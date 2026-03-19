using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class GiftCard : Product, IValidatableObject
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Card value must be positive")]
        public decimal CardValue { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        public GiftCard() { }

        public GiftCard(string name, decimal price, int quantity, decimal cardValue, DateTime purchaseDate, DateTime expiryDate)
            : base(name, price, quantity)
        {
            CardValue = cardValue;
            PurchaseDate = purchaseDate;
            ExpiryDate = expiryDate;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ExpiryDate <= PurchaseDate)
            {
                yield return new ValidationResult(
                    "Expiry date must be after purchase date.",
                    new[] { nameof(ExpiryDate) });
            }
        }

        public override string GetInfo()
        {
            return $"GiftCard: {Name}, Value: {CardValue} lv, Purchased: {PurchaseDate.ToShortDateString()}, Expires: {ExpiryDate.ToShortDateString()}";
        }
    }
}