﻿using Discord.WebSocket;

namespace DiscordBotCore.Discord.Entities
{
    class DiscordBotCoreConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
