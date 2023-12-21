﻿using Telegram.Bot;

namespace am3bot
{
    public class Bot
    {
        //https://api.telegram.org/bot{my_bot_token}/setWebhook?url={url_to_send_updates_to}
        //.........
        private static TelegramBotClient? client { get; set; }
        public static async Task<TelegramBotClient> GetTelegramBot()
        {
            if (client != null)
            {
                return client;
            }
            client = new TelegramBotClient("6875076850:AAF3_j06xe-9dswDJPQ0AaCjpK52SKoqsEw");
            string hook = "lab4botostap.azurewebsites.net";
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}
