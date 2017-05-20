using System;
using System.ComponentModel.DataAnnotations;

namespace OMDBRentals
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
