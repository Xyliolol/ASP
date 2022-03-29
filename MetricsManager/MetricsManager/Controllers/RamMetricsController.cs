﻿using Microsoft.AspNetCore.Mvc;

namespace MetricsManager.Controllers
{
    [Route("api/metrics/ram")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        private readonly ILogger<RamMetricsController> _logger;

        public RamMetricsController(ILogger<RamMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }

        [HttpGet("available/agent{agentId}")]
        public IActionResult Available([FromRoute] int agentId)
        {
            _logger.LogInformation($"Получение RAM у \t {agentId}",
               agentId);
            return Ok();
        }

        [HttpGet("available/cluster")]
        public IActionResult GetMetricsFromAllCluster()
        {
            _logger.LogInformation("Получение RAM со всех портов");
            return Ok();
        }
    }
}
