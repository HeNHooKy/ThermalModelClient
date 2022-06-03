using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalModelClient.Model
{
    public class Sensor : IdClass
    {
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("lastValue")]
        public string? LastValue { get; set; }
        [JsonProperty("coordX")]
        public string? CoordX { get; set; }
        [JsonProperty("coordY")]
        public string? CoordY { get; set; }
        [JsonProperty("coordZ")]
        public string? CoordZ { get; set; }
        [JsonProperty("lastCheck")]
        public DateTime? LastCheck { get; set; }
        [JsonProperty("blockId")]
        public Guid BlockId { get; set; }


    }
}
