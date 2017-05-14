using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Role Object according to
    /// https://discordapp.com/developers/docs/topics/permissions#role-object
    /// Roles represent a set of permissions attached to a group of users. 
    /// Roles have unique names, colors, and can be "pinned" to the side bar, causing their members to be listed separately. 
    /// Roles are unique per guild, and can have separate permission profiles for the global context (guild) and channel context.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Role id
        /// Type: Snowflake
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Role Name
        /// Type: string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// integer representation of hexadecimal color code
        /// </summary>
        [JsonProperty("color")]
        public int Color { get; set; }

        /// <summary>
        /// f this role is pinned in the user listing
        /// </summary>
        [JsonProperty("hoist")]
        public bool Hoist { get; set; }

        /// <summary>
        /// position of this role
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// permission bit set
        /// Type: Integer
        /// See Permission Bitwise Flags
        /// https://discordapp.com/developers/docs/topics/permissions#role-object
        /// </summary>
        [JsonProperty("permissions")]
        public int Permissions { get; set; }

        /// <summary>
        /// whether this role is managed by an integration
        /// Type: bool
        /// </summary>
        [JsonProperty("managed")]
        public bool Managed { get; set; }

        /// <summary>
        /// whether this role is mentionable
        /// Type: bool
        /// Type: bool
        /// </summary>
        [JsonProperty("mentionable")]
        public bool Mentionable { get; set; }
    }
}