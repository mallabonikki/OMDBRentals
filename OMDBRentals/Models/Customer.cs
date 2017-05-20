using System;
using System.ComponentModel.DataAnnotations;

namespace OMDBRentals.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

    }
}
