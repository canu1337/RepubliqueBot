using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class Update {
        [JsonProperty("update_id")]
        public int Id { get; set; }
        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}