using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMFApi.FitterFunn;
using RMFApi.Models;

namespace RMFApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RMFController : ControllerBase
    {
        //构造函数注入上下文
        private readonly rmfContext _context;
        public RMFController(rmfContext Context)
        {
            _context = Context;
        }
        // GET api/rmf/5
        [HttpGet("{id}")]
        [TokenFitter]
        public ActionResult<string> Get(int id)
        {
            var aa = _context.Invitation.ToList().Count;
            var bb = _context.Rmfuser.ToList();
            return "口令正确，返回数据："+aa;
        }

    }
}