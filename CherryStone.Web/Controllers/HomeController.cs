using CherryStone.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CherryStone.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PostsViewModel model = new PostsViewModel()
            {
                Posts = CherryStone.Domain.BLL.PostBLL.Search(1, 5, "")
            };
            return View(model);
        }
    }
}