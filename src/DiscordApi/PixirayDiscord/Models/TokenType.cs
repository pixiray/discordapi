using System;
using System.Collections.Generic;
using System.Text;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// https://discord.foxbot.me/docs/api/Discord.TokenType.html
    /// yeah sure guys ;)
    /// https://discordapp.com/developers/docs/topics/oauth2
    /// </summary>
    public enum TokenType
    {
        User,
        Bearer,
        Bot,
        Webhook
    }
}
