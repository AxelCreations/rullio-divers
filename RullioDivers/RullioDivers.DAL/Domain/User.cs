using System;
using System.ComponentModel.DataAnnotations;

namespace RullioDivers.DAL.Domain
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Names { get; set; }

        [Required]
        [StringLength(50)]
        public string LastNames { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int DiverSchoolID { get; set; }
        public DiverSchool DiverSchool { get; set; }

        [Required]
        public string License { get; set; }
        
        [Required]
        public string LicenseImage { get; set; }

        [Required]
        public Role Role { get; set; } = Role.Customer;

        [Required]
        public bool Locked { get; set; } = true;

        [Required]
        public byte[] PasswordSalt { get; set; }
        
        [Required]
        public byte[] PasswordHash { get; set; }

        [StringLength(50)]
        public string AuthToken { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime LastUpdate { get; set; }
    }
}
