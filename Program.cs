using System;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using Microsoft.Extensions.Hosting;

namespace DiscordBotInCSharp
{
    class Program

    {
        
        public static Task Main(string[] args) => new Program().MainAsync();
        private DiscordSocketClient? _client;
        private CommandService? _commands;
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;

           
            var token = "";

            

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            
            await Task.Delay(-1);


            using IHost host =
        }


        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
