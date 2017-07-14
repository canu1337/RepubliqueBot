using System;
using RepubliqueBot.Models;
using System.Collections.Generic;

namespace RepubliqueBot.Actions
{

    public class VoteBanAction : VoteAction
    {
        Message message { get; set; }
        User userAffected { get; set; }

        public VoteBanAction(Message msg, User u, Commands type = Commands.VoteBan) : base(msg, u, type)
        {
        }
        
        private void CallAction()
        {
            //add ban action here, 
            String banMessage = "Banning " + userAffected.Id;
            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}