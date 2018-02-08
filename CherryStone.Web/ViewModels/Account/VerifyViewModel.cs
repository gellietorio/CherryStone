using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CherryStone.Web.ViewModels.Account
{
    public class VerifyViewModel
    {
        public Guid Id { get; set; }
        public string VerificationCode { get; set; }
        public string Redirect { get; set; }
    }
}