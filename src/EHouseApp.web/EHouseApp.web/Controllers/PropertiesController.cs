using EHouseApp.web.Models;
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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Add(PropertyModel model)
        {
            throw new NotImplementedException();
        }
    }
}