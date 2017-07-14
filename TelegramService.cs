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

        public static void SendMessage (int group, string text, string markup = null)
        {
            SendMessage msg = new SendMessage() { ChatId = group, Text = text, ReplyMarkup = markup };
            SendMessageToTelegramAPI(msg, "sendMessage");
        }

        public static void ChangeTitle (int group, string title) {
            SendMessage msg = new SendMessage() { ChatId = group, Title = title };
            SendMessageToTelegramAPI(msg, "setChatTitle");
        }

        public static void BanUser (int group, int userId, int date) {
            SendMessage msg = new SendMessage() { ChatId = group, UserId = userId, UntilDate = date };
            SendMessageToTelegramAPI(msg, "kickChatMember");
        }

        /// <summary>
        /// Serialize a JSON object, and send it in a POST to the specified tgAPI endpoint.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        private static HttpResponseMessage SendMessageToTelegramAPI(SendMessage msg, String endpoint) {
            string json = JsonConvert.SerializeObject(msg, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            return httpClient.PostAsync(TelegramService.GetURL(endpoint), content).Result;
        }

        private static string GetURL (string method) {
            return String.Format(TelegramService.telegramURL, TelegramService.token, method);
        }
    }
}