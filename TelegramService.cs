using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using RepubliqueBot.Models;

namespace RepubliqueBot {

    public class TelegramService {
        private static string telegramURL = "https://api.telegram.org/bot{0}/{1}";
        private string token = "382765279:AAEnglUFw0z0ExA5HrI9VwSKaLq2DM3t68w";
        private HttpClient httpClient;

        public TelegramService () {
            this.httpClient = new HttpClient();
        }
        public void SendMessage (int group, string text){
            SendMessage msg = new SendMessage() { ChatId = group, Text = text };
            string json = JsonConvert.SerializeObject(msg, Newtonsoft.Json.Formatting.None, 
                            new JsonSerializerSettings { 
                                NullValueHandling = NullValueHandling.Ignore
                            });
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var r = httpClient.PostAsync(this.getURL("sendMessage"), content).Result;
        }

        private string getURL (string method) {
            return String.Format(TelegramService.telegramURL, this.token, method);
        }
    }
}