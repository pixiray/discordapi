using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// https://discordapp.com/developers/docs/resources/channel#embed-author-structure
    /// </summary>
    public class Author
    {
        /// <summary>
        /// name of author
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// url of author
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        private string _icon;
        /// <summary>
        /// url of author icon (only supports http(s) and attachments)
        /// </summary>
        [JsonProperty("icon_url")]
        [DataType(DataType.Url)]
        public string Icon
        {
            get => _icon;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    _icon = value;
                }
                else
                {
                    throw new NotSupportedException("Icon Urls must be https://");
                }
            }
        }

        /// <summary>
        /// a proxied url of author icon
        /// </summary>
        [JsonProperty("proxy_icon_url")]
        [DataType(DataType.Url)]
        public string ProxyIcon { get; set; }
    }
}