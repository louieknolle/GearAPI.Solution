using System.ComponentModel.DataAnnotations;

namespace SearchGear.Models
{
    public class Gear
    {
        public int GearId { get; set; }

        [Required]
        [StringLength(25)]
        public string Family { get; set; }

        [Required]
        [StringLength(25)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        [Required]
        [Range(0, 1500, ErrorMessage = "Price must be between 0 and 1500.")]
        public int Price { get; set; }        
    }

}