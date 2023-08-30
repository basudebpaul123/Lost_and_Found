using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Lost_and_Found.Models
{
    public partial class Claim
    {
        public Claim()
        {
            UserClaims = new HashSet<UserClaim>();
        }

        public int ClaimId { get; set; }
        public int? UserId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string UserAddress { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Contact is required.")]
        public string UserContact { get; set; }

        public virtual ICollection<UserClaim> UserClaims { get; set; }
    }
}
