﻿
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgentManager.Controllers
{
    [Route("api/metrics/network")]
    [ApiController]
    public class NetworkMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics(
           [FromRoute] TimeSpan fromTime,
           [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
