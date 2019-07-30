using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //string name = Request.Query["name"];
            //Request.Cookies[""];
            //Request.Form[""];
            //HttpContext.Session.SetInt32("age", 18);
            //var age = HttpContext.Session.GetInt32("age");
            //return Content("say hello!");

            Customer customer = new Customer() { Id = 1, Name = "kudsu" };
            return View(customer);

        }
        public IActionResult Login([FromForm]string username, [FromForm]string userpwd)
        {
            return Content($"名字是:{username};密码是:{userpwd }");
            //return Json(new { LofinName = name });
        }
        public IActionResult FanXing()
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("1", "1");

            return View();

        }
    }
    public class Customer
    {
        [DisplayName("编号")]
        public int Id { get; set; }
        [DisplayName("名称")]
        public string Name { get; set; }
    }

    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}