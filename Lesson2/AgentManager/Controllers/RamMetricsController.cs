
using Microsoft.AspNetCore.Mvc;

namespace AgentManager.Controllers
{
    [Route("api/metrics/ram")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("available")]
        public IActionResult GetFreeRamSizeMetrics()
        {
            return Ok();
        }
    }
}
