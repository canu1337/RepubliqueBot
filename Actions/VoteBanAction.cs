using System;
using RepubliqueBot.Models;
using System.Collections.Generic;

namespace RepubliqueBot.Actions
{

    public class VoteBanAction : VoteAction
    {
 
        public VoteBanAction(Message msg, string u) : base(msg, u)
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