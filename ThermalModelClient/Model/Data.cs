using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalModelClient.Model
{
    internal class Data
    {
        [JsonProperty("sensorId")]
        public Guid SensorId { get; set; }
        [JsonProperty("checkDate")]
        public DateTime CheckDate { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
