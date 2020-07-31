using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseApp.web.Models
{
    public class PropertyModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be more than 100 words.")]
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid price")]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "should not be more than 20")]
        public int NumberOfRooms { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "should not be more than 20")]
        public int NumberOfBaths { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "should not be more than 20")]
        public int NumberOfToilets { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        [Phone(ErrorMessage = "Phone number is not in correct format")]
        public string ContactPhoneNumber { get; set; }
    }
}