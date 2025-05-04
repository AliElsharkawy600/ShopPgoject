using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Company 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name ="Street Address")]
        public string? StreetAddress { get; set; }

        [MaxLength(200)]
        public string? City { get; set; }

        [MaxLength(200)]
        public string? State { get; set; }

        [MaxLength(200)]
        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [MaxLength(100)]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
    }
}
