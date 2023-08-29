using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class Weapon
    {
        [Required]
        [StringLength(250)]
        [MinLength(2)]
        public string Name { get; set; }
        [MinLength(0)]
        [MaxLength(2500)]
        [Required(AllowEmptyStrings = true)]
        public string? Description { get; set; }
        public decimal Force { get; set; }
        [Required(ErrorMessage = "The price has to be between 0 and 100000 ")]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Image { get; set; }
        public int Qty { get; set; }
        public int QtyBought { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var item = validationContext.ObjectInstance as Weapon;
            if (item == null) yield break;
            if (string.IsNullOrWhiteSpace(item.Description)) yield break;
            if (item.Description.Split(" ").Length <= 3)
                yield return new ValidationResult("Description needs to have more than 3 words please.", new[] { "Description" });
        }


    }
}
