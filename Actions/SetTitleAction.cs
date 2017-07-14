using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class SetTitleAction : IAction
    {
        Message message { get ; set; }

        public SetTitleAction (Message msg)
        {
            this.message = msg;
        } 
        void IAction.execute()
        {
            TelegramService.SetTitle(message.Chat.Id, message.Param);
        }
    }
}