using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [OutputCache( Duration = 15 )]
        public string Index()
        {
            return "Hiiii";
        }
        [OutputCache(Duration = 15)]
        public string DisplayDate()
        {
            return DateTime.Now.ToString();
        }
    }
}