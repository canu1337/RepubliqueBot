using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class InlineButton {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("callback_data")]
        public string CallbackData { get; set; }
    }
}