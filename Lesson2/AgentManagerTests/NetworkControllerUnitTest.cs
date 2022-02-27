using AgentManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace AgentManagerTests
{
    public class NetworkControllerUnitTests
    {
        private readonly NetworkMetricsController _controller;

        public NetworkControllerUnitTests()
        {
            _controller = new NetworkMetricsController();
        }


        [Fact]
        public void GetMetrics_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = _controller.GetMetrics(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
