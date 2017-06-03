using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Footer Struct
    /// https://discordapp.com/developers/docs/resources/channel#embed-footer-structure
    /// </summary>
    public class Footer
    {
        /// <summary>
        /// footer text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// url of footer icon (only supports http(s) and attachments)
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// a proxied url of footer icon
        /// </summary>
        [JsonProperty("proxy_icon_url")]
        public string IconProxyUrl { get; set; }
    }
}