﻿using System.Web;
using System.Web.Mvc;

namespace Crystal_Stevens_Week_7_lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}