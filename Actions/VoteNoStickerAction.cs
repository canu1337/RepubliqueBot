using System;
using RepubliqueBot.Models;

namespace RepubliqueBot.Actions
{
    public class VoteNoStickerAction : VoteAction
    {
        public VoteNoStickerAction(Message msg, string u, Commands type = Commands.VoteNoSticker) : base(msg, u, type)
        {
            voteType = "voteNoSticker";
        } 

        private void CallAction()
        {
            //add ban action here, 
            String banMessage = "No stickers for " + userAffected;

            TelegramService.SendMessage(message.Chat.Id, ">insinuant que c'est implémenté");
        }
    }
}