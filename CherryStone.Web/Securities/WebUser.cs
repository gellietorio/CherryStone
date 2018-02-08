using CherryStone.Domain.DTO.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CherryStone.Web.Securities
{
    public static class WebUser
    {
        public static UserResponseDto CurrentUser
        {
            get
            {
                if (HttpContext.Current.Session != null && HttpContext.Current.Session["CurrentUser"] != null)
                {
                    return (UserResponseDto)HttpContext.Current.Session["CurrentUser"];
                }

                return null;
            }
            set { HttpContext.Current.Session["CurrentUser"] = value; }
        }

        public static List<UserResponseDto> UserStores
        {
            get
            {
                if (HttpContext.Current.Session != null && HttpContext.Current.Session["UserStores"] != null)
                {
                    return (List<UserResponseDto>)HttpContext.Current.Session["UserStores"];
                }

                return null;
            }
            set { HttpContext.Current.Session["UserStores"] = value; }
        }

        public static UserResponseDto CurrentStore
        {
            get
            {
                if (HttpContext.Current.Session != null && HttpContext.Current.Session["CurrentEvent"] != null)
                {
                    return (UserResponseDto)HttpContext.Current.Session["CurrentEvent"];
                }

                return null;
            }
            set { HttpContext.Current.Session["CurrentEvent"] = value; }
        }

        public static string CurrentCategory
        {
            get
            {
                if (HttpContext.Current.Session != null && HttpContext.Current.Session["CurrentCategory"] != null)
                {
                    return (string)HttpContext.Current.Session["CurrentCategory"];
                }

                return null;
            }
            set { HttpContext.Current.Session["CurrentCategory"] = value; }
        }

        public static string RedirectAction
        {
            get
            {
                if (HttpContext.Current.Session != null && HttpContext.Current.Session["RedirectAction"] != null)
                {
                    return (string)HttpContext.Current.Session["RedirectAction"];
                }

                return null;
            }
            set { HttpContext.Current.Session["RedirectAction"] = value; }
        }

        public static string RedirectController
        {
            get
            {
                if (HttpContext.Current.Session != null && HttpContext.Current.Session["RedirectController"] != null)
                {
                    return (string)HttpContext.Current.Session["RedirectController"];
                }

                return null;
            }
            set { HttpContext.Current.Session["RedirectController"] = value; }
        }
    }
}