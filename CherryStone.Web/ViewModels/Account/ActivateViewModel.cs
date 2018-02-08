using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CherryStone.Web.ViewModels.Account
{
    public class ActivateViewModel
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Code { get; set; }
    }
}