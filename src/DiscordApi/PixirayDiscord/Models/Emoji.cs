using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Emoji Object accoding to documentation
    /// https://discordapp.com/developers/docs/resources/guild#emoji-object
    /// </summary>
    public class Emoji
    {
        /// <summary>
        /// emoji id
        /// Type: Snowflake
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// emoji name
        /// Type: String
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// roles this emoji is active for
        /// array of role object ids
        /// Type: array of role objects
        /// </summary>
        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }

        /// <summary>
        /// whether this emoji must be wrapped in colons
        /// Type: bool
        /// </summary>
        [JsonProperty("require_colons")]
        public bool RequireColons { get; set; }

        /// <summary>
        /// whether this emoji is managed
        /// Type: bool
        /// </summary>
        [JsonProperty("managed")]
        public bool Managed { get; set; }
    }
}