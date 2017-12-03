﻿using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace TamamoSharp.Modules
{
    public class TamamoModuleBase : ModuleBase<SocketCommandContext>
    {
        public async Task DelayDeleteReplyAsync(string message, int seconds = 1, bool isTTS = false,
            Embed embed = null, RequestOptions options = null)
        {
            IUserMessage msg = await ReplyAsync(message, isTTS, embed, options);
            await Task.Delay(seconds*1000);
            await msg.DeleteAsync();
        }
    }
}
