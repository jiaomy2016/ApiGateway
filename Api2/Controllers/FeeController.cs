
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json (new  {  amount=10, onlinePay=8, unPay=2 });
        }
    }
}
