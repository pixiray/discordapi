using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// The Override Object
    /// https://discordapp.com/developers/docs/resources/channel#overwrite-object
    /// </summary>
    public class PermissionOverride
    {
        /// <summary>
        /// role or user id
        /// Type: Snowflake
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// either "role" or "member"
        /// Type: String
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// permission bit set
        /// Type: Integer Bitmask
        /// </summary>
        [JsonProperty("allow")]
        public int Allow { get; set; }

        /// <summary>
        /// permission bit set
        /// Type: Integer Bitmask
        /// </summary>
        [JsonProperty("deny")]
        public int Deny { get; set; }
    }
}