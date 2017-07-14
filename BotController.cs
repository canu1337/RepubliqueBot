using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RepubliqueBot.Actions;
using RepubliqueBot.Models;

namespace RepubliqueBot
{
    public class BotController : Controller
    {
        public ActionResult Index()
        {
            var req = Request.Body;
            var json = new StreamReader(req).ReadToEnd();
            Update update = JsonConvert.DeserializeObject<Update>(json);
            IAction action;
            switch (update.Message.Command)
            {
                case Command.VoteBan : action = new VoteBanAction(update.Message) ; break;
                default : action = new NoneAction(); break;
            }
            action.execute();
            return Content("OK");
        }
    }
}