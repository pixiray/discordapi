using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Guild Implementation accoding to https://discordapp.com/developers/docs/resources/guild
    /// </summary>
    public class Guild
    {
        /// <summary>
        /// guild id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// guild name (2-100 characters)
        /// </summary>
        [JsonProperty("name")]
        [StringLength(100,MinimumLength = 2)]
        public string Name { get; set; }

        /// <summary>
        /// icon hash
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// splash hash
        /// </summary>
        [JsonProperty("splash")]
        public string Splash { get; set; }

        /// <summary>
        /// id of owner
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// {voice_region.id}
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// id of afk channel
        /// </summary>
        [JsonProperty("afk_channel_id")]
        public string AfkChannelId { get; set; }

        /// <summary>
        /// afk timeout in seconds
        /// </summary>
        [JsonProperty("afk_timeout")]
        public int AfkTimeout { get; set; }

        /// <summary>
        /// is this guild embeddable (e.g. widget)
        /// </summary>
        [JsonProperty("embed_enabled")]
        public bool EmbedEnabled { get; set; }

        /// <summary>
        /// id of embedded channel
        /// </summary>
        [JsonProperty("embed_channel_id")]
        public string EmbedChannelId { get; set; }

        /// <summary>
        /// level of verification
        /// </summary>
        [JsonProperty("verification_level")]
        public int VerificationLevel { get; set; }

        /// <summary>
        /// default message notifications level
        /// </summary>
        [JsonProperty("default_message_notifications")]
        public int DefaultNotificationsMessage { get; set; }

        /// <summary>
        /// array of role objects
        /// </summary>
        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }

        /// <summary>
        /// array of emoji objects
        /// </summary>
        [JsonProperty("emojis")]
        public List<Emoji> Emojis { get; set; }

        /// <summary>
        /// 	array of guild features
        /// </summary>
        [JsonProperty("features")]
        public List<string> Feautres { get; set; }

        /// <summary>
        /// required MFA level for the guild
        /// </summary>
        [JsonProperty("mfa_level")]
        public int MfaLevel { get; set; }

        /// <summary>
        /// date this guild was joined at
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("joined_at")]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// whether this is considered a large guild
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("large")]
        public bool Large { get; set; }

        /// <summary>
        /// is this guild unavailable
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        /// <summary>
        /// total number of members in this guild
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        /// <summary>
        /// array of voice state objects (without the guild_id key)
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("voice_states")]
        public List<VoiceState> VoiceStates { get; set; }

        /// <summary>
        /// array of guild member objects
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("members")]
        public List<Member> Members { get; set; }

        /// <summary>
        /// array of channel objects
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }

        /// <summary>
        /// array of simple presence objects, which share the same fields as Presence Update event sans a roles or guild_id key
        /// * These fields are only sent within the GUILD_CREATE event
        /// </summary>
        [JsonProperty("presences")]
        public List<Presence> Presences { get; set; }
    }
}
