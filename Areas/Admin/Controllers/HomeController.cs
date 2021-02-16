using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch06RoutingPractice.Areas.Admin.Controllers
{
    // Area Admin routing
    [Area("Admin")]
    public class HomeController : Controller
    {
        // Custom routing attribute
        // https://localhost:44328/Home/Custom/All/Page/1
        [Route("{controller}/{action}/{id}/Page/{num}")]
        public IActionResult Custom(string id = "All", int page = 1, string customAttribute = "custom")
        {
            return Content("id=" + id + ", page=" + page + ", Custom Attribute=" + customAttribute);
        }

        // Custom routing rule
        // https://localhost:44328/Home/CustomRule/All/Page/1
        [Route("{controller}/{action}/{id}/Page/{num}")]
        public IActionResult CustomRule(string id = "All", int page = 1)
        {
            return Content("Admin Custom Rule");
        }

        // Default routing - Index
        // https://localhost:44328/admin
        public IActionResult Index()
        {
            return Content("Admin Home");
        }
    }
}
