﻿using System.Web;
using System.Web.Mvc;

namespace Sistema_Parcial_Nomina
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
