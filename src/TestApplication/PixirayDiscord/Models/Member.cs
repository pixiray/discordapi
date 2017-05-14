using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Guild Member Object according to https://discordapp.com/developers/docs/resources/guild#guild-member-object
    /// Guild Member Object
    /// </summary>
    public class Member
    {
        /// <summary>
        /// user object
        /// Type: Object:User
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// his users guild nickname (if one is set)
        /// Type: string?
        /// </summary>
        [JsonProperty("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// array of role object id's
        /// Type: Array of Roles
        /// </summary>
        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }

        /// <summary>
        /// date the user joined the guild
        /// Type: DateTime
        /// </summary>
        [JsonProperty("joined_at")]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// if the user is deafened
        /// Type: bool
        /// </summary>
        [JsonProperty("deaf")]
        public bool Deaf { get; set; }

        /// <summary>
        /// if the user is muted
        /// Type: bool
        /// </summary>
        [JsonProperty("mute")]
        public bool Mute { get; set; }


        #region sample
        //{
        //    "user": {},
        //    "nick": "NOT API SUPPORT",
        //    "roles": [],
        //    "joined_at": "2015-04-26T06:26:56.936000+00:00",
        //    "deaf": false,
        //    "mute": false
        //}
        #endregion
    }
}