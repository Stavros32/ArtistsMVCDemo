﻿using System.Web;
using System.Web.Mvc;

namespace ArtistsMVCDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           // filters.Add(new AuthorizeAttribute());  //Required Log in for acces to the site
        }
    }
}
