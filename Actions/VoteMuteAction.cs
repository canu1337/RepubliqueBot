using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class VoteMuteAction : IAction
    {
        Message message { get ; set; }

        public VoteMuteAction(Message msg)
        {
            this.message = msg;
        } 

        void IAction.execute()
        {
            TelegramService service = new TelegramService();
            service.SendMessage(message.Chat.Id.ToString(), ">insinuant que c'est implémenté");
        }
    }
}