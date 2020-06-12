﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Luna.Clients.Models.Controller
{
    public class GetARealTimeServiceEndpointByEndpointIdUserProductAndDeploymentResponse
    {
        public List<Operation> operations { get; set; }
        public class Operation
        {
            public string endpointId { get; set; }
            public string startTimeUtc { get; set; }
            public string completeTimeUtc { get; set; }
            public string scoringUrl { get; set; }
            public String primaryKey { get; set; }
            public String secondaryKey { get; set; }
            public String description { get; set; }
        }
        public GetARealTimeServiceEndpointByEndpointIdUserProductAndDeploymentResponse()
        {
            this.operations = new List<Operation>();
        }
    }
}