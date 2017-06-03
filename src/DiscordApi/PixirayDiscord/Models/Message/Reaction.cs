using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Reaction Object
    /// https://discordapp.com/developers/docs/resources/channel#reaction-object
    /// </summary>
    public class Reaction
    {
        /// <summary>
        /// times this emoji has been used to react
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// whether the current user reacted using this emoji
        /// </summary>
        [JsonProperty("me")]
        public bool Me { get; set; }

        /// <summary>
        /// emoji information
        /// </summary>
        [JsonProperty("emoji")]
        public Emoji Emoji { get; set; }
    }
}