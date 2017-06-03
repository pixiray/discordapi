using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Embed Video
    /// https://discordapp.com/developers/docs/resources/channel#embed-video-structure
    /// </summary>
    public class Video
    {
        /// <summary>
        /// source url of video
        /// </summary>
        [JsonProperty("url")]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        /// <summary>
        /// height of video
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// width of the video
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}