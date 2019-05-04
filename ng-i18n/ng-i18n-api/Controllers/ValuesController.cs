using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ng_i18n_api.Services;

namespace ng_i18n_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ValueService _valueService;

        public ValuesController(ValueService valueService)
        {
            _valueService = valueService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<TValue> Get()
        {
            return new TValue { Value = _valueService.Get() };
        }
    }

    public class TValue
    {
        public int Value { set; get; }
    }
}
