using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class VoteNoStickerAction : IAction
    {
        Message message { get ; set; }

        public VoteNoStickerAction (Message msg)
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