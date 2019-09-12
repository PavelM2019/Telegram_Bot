using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram_Bot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatid = message.Chat.Id;
            var messageid = message.MessageId;

            //Bot logic

            await client.SendTextMessageAsync(0, "", replyToMessageId: 0);
        }
    }
}