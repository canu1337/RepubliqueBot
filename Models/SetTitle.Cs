using System;
using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class SetTitle {
        [JsonProperty("chat_id")]
        public int ChatId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}