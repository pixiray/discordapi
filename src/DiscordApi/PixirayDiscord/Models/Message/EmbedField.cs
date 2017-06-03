using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// https://discordapp.com/developers/docs/resources/channel#embed-field-structure
    /// </summary>
    public class EmbedField
    {
        /// <summary>
        /// name of the field
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// value of the field
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// whether or not this field should display inline
        /// </summary>
        [JsonProperty("inline")]
        public bool Inline { get; set; }
    }
}