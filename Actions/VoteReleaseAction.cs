using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class VoteReleaseAction : IAction
    {
        Message message { get ; set; }

        public VoteReleaseAction (Message msg)
        {
            this.message = msg;
        } 

        void IAction.execute()
        {
            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}