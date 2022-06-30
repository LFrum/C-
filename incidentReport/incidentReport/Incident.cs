using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentReport
{
    class Incident
    {
        public int IncdientsId { get; set; }

        public int CustomerId { get; set; }

        public string ProductCode { get; set; }

        public int? TechId { get; set; } // int? make it possible for nullable and won't throw execption

        public DateTime DateOpened { get; set; }

        public DateTime DateClosed { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
