using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseApp.web.Controllers
{
    public class PropertiesController : Controller
    {
        public PropertiesController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}