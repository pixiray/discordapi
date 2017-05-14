using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Channel Implementation according to: https://discordapp.com/developers/docs/resources/channel#guild-channel-object
    /// 
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// the id of this channel (will be equal to the guild if it's the "general" channel)
        /// Type: snowflake
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// the id of the guild
        /// Type: Snowflake
        /// </summary>
        [JsonProperty("guild_id")]
        public string GuildId { get; set; }

        /// <summary>
        /// the name of the channel (2-100 characters)
        /// Type: String
        /// </summary>
        [JsonProperty("name")]
        [StringLength(100,MinimumLength = 2)]
        public string Name { get; set; }

        /// <summary>
        /// "text" or "voice"
        /// Type: String
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// sorting position of the channel
        /// Type: int
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// should always be false for guild channels
        /// Type: bool
        /// </summary>
        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// an array of overwrite objects
        /// Type: array of objects:overrites
        /// </summary>
        [JsonProperty("permission_overwrites")]
        public List<PermissionOverride> PermissionOverrides { get; set; }

        /// <summary>
        /// the channel topic (0-1024 characters)
        /// Type: string
        /// </summary>
        [JsonProperty("topic")]
        [StringLength(1024,MinimumLength = 0)]
        public string Topic { get; set; }

        /// <summary>
        /// the id of the last message sent in this channel
        /// Type: Snowflake
        /// </summary>
        [JsonProperty("last_message_id")]
        public string LastMessageId { get; set; }

        /// <summary>
        /// the bitrate (in bits) of the voice channel
        /// Type: int
        /// </summary>
        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        /// <summary>
        /// the user limit of the voice channel
        /// Type: int
        /// </summary>
        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }


        #region sample channel

        ////Sample Text Channel
        //{
        //    "id": "41771983423143937",
        //    "guild_id": "41771983423143937",
        //    "name": "general",
        //    "type": "text",
        //    "position": 6,
        //    "is_private": false,
        //    "permission_overwrites": [],
        //    "topic": "24/7 chat about how to gank Mike #2",
        //    "last_message_id": "155117677105512449"
        //}

        ////Sample Voice Channel
        //{
        //    "id": "155101607195836416",
        //    "guild_id": "41771983423143937",
        //    "name": "ROCKET CHEESE",
        //    "type": "voice",
        //    "position": 5,
        //    "is_private": false,
        //    "permission_overwrites": [],
        //    "bitrate": 64000,
        //    "user_limit": 0
        //}

        #endregion
    }
}