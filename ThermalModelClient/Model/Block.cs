using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalModelClient.Model
{
    internal class Block : IdClass
    {
        [JsonProperty("clusterId")]
        public Guid ClusterId { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("sensors")]
        public IEnumerable<Sensor>? Sensors { get; set; }

        public override string ToString()
        {
            return Name ?? Id.ToString();
        }
    }
}
