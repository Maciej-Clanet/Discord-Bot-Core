﻿using Discord;
using Discord.WebSocket;
using DiscordBotCore.Discord.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotCore.Discord
{
    public class Connection
    {

        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;


        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }
        
        internal async Task ConnectAsync(DiscordBotCoreConfig config)
        {
            _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);

            await _client.StartAsync();

            await Task.Delay(-1);
        }

    }
}
