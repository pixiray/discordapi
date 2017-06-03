using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Pixiray.Discord.Api.Models;

namespace Pixiray.Discord.Api
{
    /// <summary>
    /// Rest API Implementation of the Discord Client
    /// </summary>
    public partial class DiscordClient
    {
        /// <summary>
        /// The Secret Token to call the APIs
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// https://discordapp.com/developers/docs/resources/channel#get-channel
        /// GET/channels/{channel.id}
        /// Get a channel by ID. Returns a guild channel or dm channel object.
        /// </summary>
        /// <returns></returns>
        public async Task<Channel> GetCurrentChannelAsync()
        {
            return new Channel();
        }
    }
}
