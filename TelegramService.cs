using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using RepubliqueBot.Models;

namespace RepubliqueBot {

    public static class TelegramService {
        private static string telegramURL = "https://api.telegram.org/bot{0}/{1}";
        private static string token = "382765279:AAEnglUFw0z0ExA5HrI9VwSKaLq2DM3t68w";
        private static HttpClient httpClient = new HttpClient();
        public static void SendMessage (int group, string text){
            SendMessage msg = new SendMessage() { ChatId = group, Text = text };
            string json = JsonConvert.SerializeObject(msg, Newtonsoft.Json.Formatting.None, 
                            new JsonSerializerSettings { 
                                NullValueHandling = NullValueHandling.Ignore
                            });
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var r = httpClient.PostAsync(TelegramService.getURL("sendMessage"), content).Result;
        }

        public static void SetTitle (int group, string title) {
            SetTitle msg = new SetTitle() { ChatId = group, Title = title };
            string json = JsonConvert.SerializeObject(msg, Newtonsoft.Json.Formatting.None, 
                            new JsonSerializerSettings { 
                                NullValueHandling = NullValueHandling.Ignore
                            });
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var r = httpClient.PostAsync(TelegramService.getURL("setChatTitle"), content).Result;
        }

        private static string getURL (string method) {
            return String.Format(TelegramService.telegramURL, TelegramService.token, method);
        }
    }
}