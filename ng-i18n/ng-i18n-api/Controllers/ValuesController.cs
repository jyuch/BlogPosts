using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ng_i18n_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<TValue> Get()
        {
            return new TValue { Value = 0 };
        }
    }

    public class TValue
    {
        public int Value { set; get; }
    }
}
