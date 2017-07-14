using System;
using Newtonsoft.Json;

namespace RepubliqueBot.Models
{
    public class Message {
        [JsonProperty("message_id")]
        public int Id { get; set; }
        [JsonProperty("from")]
        public User From { get; set; }
        [JsonProperty("chat")]
        public Chat Chat { get; set; }
        [JsonProperty("date")]
        public int Date { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }

        public Command Command {
            get
            {
                string cmdTxt = this.Text == null ? String.Empty : this.Text.Split(' ')[0].Replace("@RepubliqueBot", String.Empty);
                Command cmd;
                switch (cmdTxt){
                    case "/voteban" : cmd = Command.VoteBan; break;
                    default : cmd = Command.None; break;
            }
                return cmd;
            }
        }
    }
}