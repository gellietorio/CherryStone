using CherryStone.Domain.Infrastructure;
using CherryStone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.Models
{
    public class User : BaseModel
    {
        public User()
        {
            this.Status = LoginStatus.Unconfirmed;
            this.Gender = Gender.Male;
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public string RegistrationCode { get; set; }
        public int LoginAttempts { get; set; }
        public LoginStatus Status { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        /* Navigator (relationships) */
        public virtual ICollection<UserExternalLogin> ExternalLogins { get; set; }
    }
}
