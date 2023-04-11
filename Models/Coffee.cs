using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)] public string Name { get; set; }

        [Required]
        [StringLength(25), MinLength(3)] public string Roast { get; set; }

        public int BeanVarietyId { get; set; }
        public BeanVariety BeanVariety { get; set; }
    }
}
