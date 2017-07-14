using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class VoteMuteAction : VoteAction
    {
        public VoteMuteAction(Message msg, string u, Commands type = Commands.VoteMute) : base(msg, u, type)
        {
            voteType = "voteMute";
        } 

        private void CallAction()
        {
            //add ban action here, 
            String banMessage = "Muting " + userAffected;

            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}