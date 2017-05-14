using System;
using System.Collections.Generic;
using System.Text;

namespace Pixiray.Discord.Api.Models
{
    /// <summary>
    /// Connection State
    /// </summary>
    public enum ConnectionState : byte
    {
        Disconnected,
        Connecting,
        Connected,
        Disconnecting
    }
}
