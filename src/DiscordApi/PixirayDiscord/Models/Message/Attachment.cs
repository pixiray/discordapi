using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// The Attachment Object
    /// https://discordapp.com/developers/docs/resources/channel#attachment-object
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// attachment id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// name of file attached
        /// </summary>
        [JsonProperty("filename")]
        public string FileName { get; set; }

        /// <summary>
        /// size of file in bytes
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// source url of file
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// a proxied url of file
        /// </summary>
        [JsonProperty("proxy_url")]
        public string ProxyUrl { get; set; }

        /// <summary>
        /// height of file (if image)
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// width of file (if image)
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}