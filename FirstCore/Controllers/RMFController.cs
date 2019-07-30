using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstCore.Controllers
{
    public class RMFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}