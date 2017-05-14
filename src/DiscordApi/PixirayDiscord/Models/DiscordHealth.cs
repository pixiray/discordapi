using System;
using System.Collections.Generic;
using System.Text;

namespace Pixiray.Discord.Api.Models
{
    public class DiscordHealth
    {
        public string API { get; set; }
        public string Gateway { get; set; }
        public string CloudFlare { get; set; }
        public string Voice { get; set; }
        public string ResponseTime { get; set; }
        public List<string> Incidents { get; set; }
    }
}
