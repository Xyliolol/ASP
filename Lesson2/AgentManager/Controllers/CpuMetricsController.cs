using Microsoft.AspNetCore.Mvc;
using System;
using AgentManager.Enum.EnumClass;

namespace AgentManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics(
             [FromRoute] TimeSpan fromTime,
             [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercentile(
            [FromRoute] TimeSpan fromTime,
            [FromRoute] TimeSpan toTime,
            [FromRoute] Percentile percentile)
        {
            return Ok();
        }
    }
}
