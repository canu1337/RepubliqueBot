using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class VoteReleaseAction : VoteAction
    {
        public VoteReleaseAction(Message msg, string u, Commands type = Commands.VoteRelease) : base(msg, u, type)
        {
            voteType = "voteRelease";
        } 

        private void CallAction()
        {
            //add ban action here, 
            String banMessage = "Releasing " + userAffected;

            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}