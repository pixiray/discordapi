using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// User Entity Implementation
    /// https://discordapp.com/developers/docs/resources/user
    /// </summary>
    public class User
    {
        /// <summary>
        /// the user's id
        /// EmbedField: id
        /// Type: snowflake
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// the user's username, not unique across the platform
        /// Type: string
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// the user's 4-digit discord-tag
        /// Type: string
        /// </summary>
        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        /// <summary>
        /// the user's avatar hash
        /// Type: string
        /// </summary>
        //TODO: Convert to Image via Library
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        //TODO: Implement the Image Convertion
        //public Task<Image> GetAvatarImageAsync()
        //{

        //}

        /// <summary>
        /// whether the user belongs to an OAuth2 application
        /// Type: bool
        /// </summary>
        [JsonProperty("bot")]    
        public bool IsBot { get; set; }

        /// <summary>
        /// whether the user has two factor enabled on their account
        /// Type: bool
        /// </summary>
        [JsonProperty("mfa_enabled")]
        public bool MfaEnabled { get; set; }

        /// <summary>
        /// whether the email on this account has been verified
        /// Type: bool
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// the user's email
        /// Type: string
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
