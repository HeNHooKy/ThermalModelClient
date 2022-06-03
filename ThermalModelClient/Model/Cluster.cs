using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalModelClient.Model
{
    internal class Cluster : IdClass
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("blocks")]
        public IEnumerable<Block>? Blocks { get; set; }

        public override string ToString()
        {
            return Name ?? Id.ToString();
        }
    }
}
