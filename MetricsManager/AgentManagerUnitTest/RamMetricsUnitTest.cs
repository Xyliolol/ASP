using AgentManager.Controllers;
using AgentManager.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace AgentManagerUnitTest
{
    public class RamControllerUnitTests
    {
        private readonly RamMetricsController _controller;
        private readonly Mock<RamMetricsRepository> _mock;

        public RamControllerUnitTests()
        {
            _mock = new Mock<RamMetricsRepository>();
            _controller = new RamMetricsController(new Mock<ILogger<RamMetricsController>>().Object, _mock.Object);
        }


        [Fact]
        public void GetFreeRamSizeMetrics_ReturnsOk()
        {
            var result = _controller.GetFreeRamSizeMetrics();

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}