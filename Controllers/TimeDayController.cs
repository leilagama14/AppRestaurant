using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRestaurant.Models;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeDayController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TimeDay> RetrieveTimeDay()
        {
            return null;
        }
    }
}
