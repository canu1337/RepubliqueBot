using System;
using RepubliqueBot.Models;
using System.Collections.Generic;

namespace RepubliqueBot.Actions
{

    public class VoteBanAction : VoteAction
    {
 
        public VoteBanAction(Message msg, string u, Commands type = Commands.VoteBan) : base(msg, u, type)
        {
            voteType = "voteBan";
        }
        
        private void CallAction()
        {
            //add ban action here, 
            String banMessage = "Banning " + userAffected;

            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}