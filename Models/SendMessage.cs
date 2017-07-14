using System;
using System.Collections.Generic;
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
        public InlineKeyboard ReplyMarkup { get; set; }
    }
}