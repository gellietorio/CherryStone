using CherryStone.Domain.CustomModels;
using CherryStone.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CherryStone.Web.ViewModels.Home
{
    public class PostsViewModel
    {
        public Page<CompletePost> Posts { get; set; }
    }
}