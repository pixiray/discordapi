using Newtonsoft.Json;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Voice State according to specification
    /// https://discordapp.com/developers/docs/resources/voice#voice-state-object
    /// </summary>
    public class VoiceState
    {
        [JsonProperty("guild_id")]
        public string GuildId { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("deaf")]
        public bool Deaf { get; set; }

        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("self_deaf")]
        public bool SelfDeaf { get; set; }

        [JsonProperty("self_mute")]
        public bool SelfMute { get; set; }

        [JsonProperty("suppress")]
        public bool Suppress { get; set; }

        #region sample
        //Voice State Example
        //{
        //    "channel_id": "157733188964188161",
        //    "user_id": "80351110224678912",
        //    "session_id": "90326bd25d71d39b9ef95b299e3872ff",
        //    "deaf": false,
        //    "mute": false,
        //    "self_deaf": false,
        //    "self_mute": true,
        //    "suppress": false
        //}
        #endregion
    }
}