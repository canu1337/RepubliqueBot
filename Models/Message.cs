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

        public Commands Command {
            get
            {
                string cmdTxt = this.Text == null ? String.Empty : this.Text.Split(' ')[0].Replace("@RepubliqueBot", String.Empty);
                Commands cmd;
                switch (cmdTxt){
                    case "/voteban" : cmd = Commands.VoteBan; break;
                    case "/votemute" : cmd = Commands.VoteMute; break;
                    case "/votenosticker" : cmd = Commands.VoteNoSticker; break;
                    case "/voterelease" : cmd = Commands.VoteRelease; break;
                    case "/settitle" : cmd = Commands.SetTitle; break;
                    case "/setpicture" : cmd = Commands.SetPicture; break;
                    default : cmd = Commands.None; break;
            }
                return cmd;
            }
        }

        public string Param {
            get 
            {
                return this.Text == null ? String.Empty : this.Text.Replace(this.Text.Split(' ')[0], String.Empty);
            }
        }
    }
}