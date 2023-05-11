using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentsApp
{
    public class Incident
    {
        public int id { get; set; }
        public List<Double> parameters { get; set; }
        public int priority { get; set; }

        public Incident(int id)
        {
            this.id = id;
            parameters = new List<Double>();
        }
    }
}
