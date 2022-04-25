using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Types
    {
        [JsonProperty("type")]
        public Description Type { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }
}
