using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            var now = DateTime.Now;
            return Json(now);
        }
    }
}
