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
            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}