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
    public class UserExternalLogin: BaseModel
    {
        [Required]
        public Guid? UserId { get; set; }
        public string Key { get; set; }
        public string OpenId { get; set; }
        public LoginProvider Provider { get; set; }

        /* Navigation (relationships) */
        public virtual User User { get; set; }
    }
}
