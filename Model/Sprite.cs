using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sprite
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

    }
}
