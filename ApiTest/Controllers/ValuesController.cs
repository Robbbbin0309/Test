using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<DataModel> Get(Guid id)
        {
            var model = DataService.Get(id);

            if (model == null) return NotFound();

            return model;
        }

        //GetAll Data
        [HttpGet]
        public ActionResult<List<DataModel>> GetAll() => DataService.GetDataModels();
    }
}
