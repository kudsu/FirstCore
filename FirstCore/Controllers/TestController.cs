using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FirstCore.Model;
using FirstCore.Models;
using FirstCore.Models.RMFfitters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstCore.Controllers
{
    public class TestController : Controller
    {
        //构造函数注入上下文
        private readonly rmfContext _context;
        public TestController(rmfContext Context)
        {
            _context = Context;
        }
        public IActionResult Tset()
        {
            var aa = _context.Invitation.ToList();
            return Content("1");
        }
        public IActionResult TokenCustomerValidateTest()
        {
            Dictionary<string, object> payLoad = new Dictionary<string, object>();
            payLoad.Add("sub", "rober");
            payLoad.Add("jti", Guid.NewGuid().ToString());
            payLoad.Add("nbf", null);
            payLoad.Add("exp", null);
            payLoad.Add("iss", "roberIssuer");
            payLoad.Add("aud", "roberAudience");
            payLoad.Add("age", 30);

            var encodeJwt = JWTTokenOptions.CreateToken(payLoad, 30);

            var result = JWTTokenOptions.Validate(encodeJwt, (load) =>
            {
                var success = true;
                //验证是否包含aud 并等于 roberAudience
                success = success && load["aud"]?.ToString() == "roberAudience";

                //验证age>20等
                int.TryParse(load["age"].ToString(), out int age);
                //Assert.IsTrue(age > 30);
                //其他验证 jwt的标识 jti是否加入黑名单等

                return success;
            });
            //Assert.IsTrue(result);
            return Content("");
        }
        [TokenFitter]
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
        public IActionResult Login()
        {
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