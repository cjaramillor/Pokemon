using Newtonsoft.Json;

namespace Model
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("stats")]
        public List<Status> Stats { get; set; }

        [JsonProperty("abilities")]
        public List<Ability> Habilities { get; set; }

        [JsonProperty("moves")]
        public List<Movement> Moves { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("height")]
        public Double Height { get; set; }

        [JsonProperty("weight")]
        public Double Weight { get; set; }

        [JsonProperty("types")]
        public List<Types> Types { get; set; }

        [JsonProperty("sprites")]
        public Sprite Sprites { get; set; }

    }
}