using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class Chat {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("all_members_are_administrators")]
        public bool AllMemberAreAdministrator { get; set;}
    }
}