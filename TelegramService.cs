using System;
using System.Net.Http;
using System.Text;
using RepubliqueBot.Models;

namespace RepubliqueBot {

    public class TelegramService {
        private static string telegramURL = "https://api.telegram.org/bot{0}/{1}";
        private string token = "";
        private HttpClient httpClient;

        public TelegramService () {
            this.httpClient = new HttpClient();
        }
        public void SendMessage (string group, string text, string markup){
            SendMessage msg = new SendMessage() { ChatId = group, Text = text, ReplyMarkup = markup };
            StringContent content = new StringContent(msg.ToString(), Encoding.UTF8, "application/json");
            var r = httpClient.PostAsync(this.getURL(TelegramMethod.SendMessage), content);
        }


        private string getURL (TelegramMethod method) {
            string meth;
            switch (method){
                case TelegramMethod.SendMessage : meth = "sendMessage"; break;
                default : meth = ""; break;
            }
            return String.Format(TelegramService.telegramURL, this.token, meth);
        }
    }
}