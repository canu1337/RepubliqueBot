using System;
using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class SendMessage {
        [JsonProperty("chat_id")]
        public int ChatId { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("reply_to_message_id")]
        public int? ReplyTo { get; set; }
        [JsonProperty("reply_markup")]
        public string ReplyMarkup { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("until_date")]
        public int UntilDate { get; set; }
        [JsonProperty("can_send_messages")]
        public bool CanSendMessages { get; set; }
        [JsonProperty("can_send_other_messages")]
        public bool CanSendOtherMessages { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}