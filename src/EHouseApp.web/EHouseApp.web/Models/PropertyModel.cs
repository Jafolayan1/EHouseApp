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
        [StringLength(maximumLength: 25, MinimumLength = 8)]
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Cannot be more than  20")]
        public int NumberOfRooms { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Cannot be more than  20")]
        public int NumberOfBaths { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Cannot be more than  20")]
        public int NumberOfToilets { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNumber { get; set; }
    }
}