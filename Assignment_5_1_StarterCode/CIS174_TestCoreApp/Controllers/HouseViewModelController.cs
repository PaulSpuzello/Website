using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : Controller
    {
        List<String> _houses = new List<string>
        {
            "4",
            "1854",
            "05/28/1973",
            "Carpet"
        };

        List<String> _houses2 = new List<string>
        {
            "3",
            "1675",
            "10/17/2015",
            "Hardwood"
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Index()
        {
            return _houses;
        }

        [HttpGet("{Bedrooms}")]
        public ActionResult<int> Get(int Bedrooms)
        {
            return Json(Ok());
        }

        [HttpGet("{SqaureFeet}")]
        public ActionResult<int> get(int SqaureFeet)
        {
            return Ok();

            //return notfound();
        }

        [HttpPost("{HouseViewModel}")]
        public ActionResult<int> Post(int HouseViewModel)
        {
            return Json(StatusCode(201));
        }
    }

    public class ValueModel
    {
    }
}

