﻿using System.Web;
using System.Web.Mvc;

namespace Hotel_Bengali
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
