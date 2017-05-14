using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Pixiray.Discord.Api.Models;

namespace Pixiray.Discord.Api
{
    /// <summary>
    /// Utilities for the Discord Client
    /// </summary>
    public partial class DiscordClient
    {
        /// <summary>
        /// Checks the Overall Health of Discord
        /// </summary>
        /// <returns></returns>
        public async Task<DiscordHealth> GetDiscordHealthAsync()
        {
            DiscordHealth health = new DiscordHealth();
            //Check client Internet Connection first

            //Check Discord Status
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("https://status.discordapp.com/");

            if (result.StatusCode == HttpStatusCode.OK)
            {
                //TODO: Parse Information in DiscordHealth
                return health;
            }
            throw new Exception();
        }
    }
}
