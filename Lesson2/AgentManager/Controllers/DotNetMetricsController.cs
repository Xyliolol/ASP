
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgentManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DotNetMetricsController : ControllerBase
    {
        [HttpGet("errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetErrorsCountMetrics(
            [FromRoute] TimeSpan fromTime,
            [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }

}
