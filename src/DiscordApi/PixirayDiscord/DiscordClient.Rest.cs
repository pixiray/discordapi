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

    }
}
