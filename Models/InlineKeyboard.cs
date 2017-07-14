using System.Collections.Generic;
using Newtonsoft.Json;

namespace RepubliqueBot.Models 
{
    public class InlineKeyboard 
    {
        public InlineKeyboard(InlineButton btn1, InlineButton btn2) {
            keyboard = new List<List<InlineButton>>();
            keyboard.Add(new List<InlineButton> {btn1, btn2});
        }
        public List<List<InlineButton>> keyboard;
    }
}