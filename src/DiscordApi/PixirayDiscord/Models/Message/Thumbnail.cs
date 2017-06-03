using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Thumbnail Structure
    /// </summary>
    public class Thumbnail
    {
        private string _url;

        /// <summary>
        /// source url of thumbnail (only supports http(s) and attachments)
        /// </summary>
        [JsonProperty("url")]
        [DataType(DataType.Url)]
        public string Url
        {
            get => _url;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    _url = value;
                }
                else
                {
                    throw new NotSupportedException("Thumbnail Urls must be https://");
                }
            }
        }

        /// <summary>
        /// a proxied url of the thumbnail
        /// </summary>
        [JsonProperty("proxy_url")]
        [DataType(DataType.Url)]
        public string Proxy { get; set; }

        /// <summary>
        /// height of thumbnail
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// width of thumbnail
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}