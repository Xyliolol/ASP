using System.Collections.Generic;

namespace MetricsManager.Models
{
    public class AgentModel
    {
        public class AgentsModel
        {
            private readonly List<AgentInfo> _data;

            public AgentsModel()
            {
                _data = new List<AgentInfo>();
            }

            public IReadOnlyList<AgentInfo> GetAgentsInfo()
            {
                return _data;
            }
        }
    }
}
