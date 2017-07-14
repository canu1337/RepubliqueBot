using System;
using RepubliqueBot.Models;
using System.Collections.Generic;

namespace RepubliqueBot.Actions
{

    public class VoteBanAction : VoteAction
    {
        Message message { get; set; }
        User userAffected { get; set; }

        public VoteBanAction(Message msg, User u, Command type = Command.VoteBan) : base(msg, u, type)
        {
        }
        
        private void CallAction()
        {
            //add ban action here, 
            String message = "Banning " + userAffected.Id;
        }
    }

}