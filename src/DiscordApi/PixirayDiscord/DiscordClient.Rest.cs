﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pixiray.Discord.Api.Models;

namespace Pixiray.Discord.Api
{
    /// <summary>
    /// REST API Implementation of the Discord Client
    /// </summary>
    public partial class DiscordClient
    {
        /// <summary>
        /// The Secret Token to call the APIs
        /// </summary>
        public string Token { get; set; }

        #region Channel

        /// <summary>
        /// Get all Channels from Guild by Guild Id
        /// </summary>
        /// <param name="guildId">The Id of the Guild by string</param>
        /// <returns>List of Channels</returns>
        public async Task<List<Channel>> GetChannels(string guildId)
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", Token);
                }
                else
                    throw new ArgumentException("Token empty or null");

                try
                {
                    var request =
                        await client.GetAsync(new Uri($"https://discordapp.com/api/guilds/{guildId}/channels"));
                    if (request.IsSuccessStatusCode)
                    {
                        try
                        {
                            var result = await request.Content.ReadAsStringAsync();
                            var list = JsonConvert.DeserializeObject<List<Channel>>(result);
                            return list;
                        }
                        catch (Exception e)
                        {
                            //Logger
                            throw new Exception(e.Message);
                        }
                    }
                    else
                    {
                        throw new WebException(request.StatusCode.ToString(), new WebException(request.ReasonPhrase));
                    }
                }
                catch (Exception e)
                {
                    //Logger
                    throw new Exception(e.Message);
                }
            }
        }

        /// <summary>
        /// Get all Channels from Guild
        /// Overlaod Method from GetChannels(string guildId)
        /// </summary>
        /// <param name="guild">Guild Object</param>
        /// <returns>List of Channels</returns>
        public async Task<List<Channel>> GetChannels(Guild guild)
        {
            //Returns the list of channels in a guild if the guild.id is not empty or null
            return String.IsNullOrEmpty(guild.Id)
                ? throw new ArgumentException("Guild:Id cannot be null")
                : await GetChannels(guild.Id);
        }

        #endregion //End of Region Channel in Discord REST Client

        public async Task<List<Guild>> GetGuilds()
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", Token);
                }
                else
                    throw new ArgumentException("Token empty or null");

                try
                {
                    var request =
                        await client.GetAsync(new Uri($"https://discordapp.com/api/users/@me/guilds"));
                    if (request.IsSuccessStatusCode)
                    {
                        try
                        {
                            var result = await request.Content.ReadAsStringAsync();
                            var list = JsonConvert.DeserializeObject<List<Guild>>(result);
                            return list;
                        }
                        catch (Exception e)
                        {
                            //Logger
                            throw new Exception(e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    //Logger
                    throw new Exception(e.Message);
                }
            }
            return null;
        }

        /// <summary>
        /// Method Calls the Discord Rest Api to retrieve the Gateway Url
        /// </summary>
        /// <returns>Gateway Url</returns>
        public async Task<string> ObtainGateway()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    if (!string.IsNullOrEmpty(Token))
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.DefaultRequestHeaders.Add("Authorization", Token);
                    }
                    else
                        throw new ArgumentException("Token empty or null");

                    var request = await client.GetAsync(new Uri("https://discordapp.com/api/gateway"));
                    if (request.IsSuccessStatusCode)
                    {
                        var result = await request.Content.ReadAsStringAsync();
                        dynamic obj = JsonConvert.DeserializeObject(result);
                        if (obj == null)
                            throw new WebException(request.StatusCode.ToString(),
                                new WebException(request.ReasonPhrase));
                        string r = obj["url"].ToString();
                        return r;
                    }
                    else
                    {
                        throw new WebException(request.StatusCode.ToString(), new WebException(request.ReasonPhrase));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
