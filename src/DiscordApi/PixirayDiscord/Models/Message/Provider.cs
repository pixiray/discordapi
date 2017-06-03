using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Provider Object
    /// https://discordapp.com/developers/docs/resources/channel#embed-provider-structure
    /// </summary>
    public class Provider
    {
        /// <summary>
        /// name of provider
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// url of provider
        /// </summary>
        [JsonProperty("url")]
        [DataType(DataType.Url)]
        public string Url { get; set; }
    }
}