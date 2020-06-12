using System;
using System.Collections.Generic;
using System.Text;

namespace Luna.Clients.Models.Controller.Backend
{
    public class GetAllPublishedPipelinesResponse
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String LastModifiedDate { get; set; }
    }
}
