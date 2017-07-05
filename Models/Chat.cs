using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class Chat {
        [JsonProperty("id")]
        int Id { get; set; }
        [JsonProperty("title")]
        string Title { get; set; }
        [JsonProperty("type")]
        string Type { get; set; }
        [JsonProperty("all_members_are_administrators")]

        bool AllMemberAreAdministrator { get; set;}
    }
}