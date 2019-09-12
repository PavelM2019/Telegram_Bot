using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram_Bot.Models.Commands ;

namespace Telegram_Bot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;

        public static List<Command> commandslist;

        public static IReadOnlyList<Command> Commands { get => commandslist.AsReadOnly(); }
        public static async Task<TelegramBotClient> Get()
        {
            if(client != null)
            {
                return client;
            }

            commandslist = new List<Command>();
            commandslist.Add(new HelloCommand());
            //Add more commands

            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync("");

            return client;
        }
    }
}