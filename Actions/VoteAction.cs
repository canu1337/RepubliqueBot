using RepubliqueBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepubliqueBot.Actions
{
    public class VoteAction : IAction
    {
        Message message { get; set; }
        string userAffected { get; set; }

        private string returnMessage;
        private string inlineKeyboard;

        private Dictionary<string, Boolean> votes;

        public VoteAction(Message msg, string u, Commands type)
        {
            //Get initial message
            this.message = msg;
            this.userAffected = u;

            String voteType = "";

            switch (type)
            {
                case Commands.VoteBan: voteType = "voteBan"; break;
                case Commands.VoteMute: voteType = "voteMute"; break;
                case Commands.VoteNoSticker: voteType = "voteNoSticker"; break;
                case Commands.VoteRelease: voteType = "voteRelease"; break;
                default: return;
            }

            //Craft inline keyboard
            inlineKeyboard = "[{text:'Yes',callback_data:'yes_" + type + "_" + u + "'},{text:'No',callback_data:'no_" + type + "_" + u + "'}]";

            //Write message
            //TODO: get vote number from settings
            returnMessage = "Initiated " + voteType + " for " + u + ". \n 5 Votes needed.";

            votes = new Dictionary<string, Boolean>();

        }

        void IAction.execute()
        {
            TelegramService.SendMessage(message.Chat.Id, returnMessage, inlineKeyboard);
        }

        void AddVote(string u, Boolean vote)
        {
            if (votes.ContainsKey(u))
                votes[u] = vote;
            else
                votes.Add(u, vote);

            CountVotes();
        }

        private void CountVotes()
        {
            //Go through the vote dictionary. If we have > 5 votes, start the action.
            //TODO: Make votecount dependant on options

            int numberOfVotes = 0;

            foreach (bool vote in votes.Values)
            {
                if (vote)
                    numberOfVotes++;
            }

            if (numberOfVotes >= 5)
                CallAction();
        }

        private void CallAction()
        {
            //To be overriden by other votes
        }
    }

}
