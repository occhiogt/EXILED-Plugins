using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Server_Moderation
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Shows debug logs in the console.")]
        public bool Debug { get; set; } = false;

        [Description("MySQL connection string.")]
        public string ConnectionString { get; set; } = "....";

        [Description("Discord BOT connection token.")]
        public string BotToken { get; set; } = "";
        public string ChannelId { get; set; } = "";
        public ulong GuildIdLogs { get; set; } = 0;

        [Description("SERVER STATUS bot connection token.")]
        public string BotTokenServerStatus { get; set; } = "";
        public string ChannelIdServerStatus { get; set; } = "";
        public ulong GuildIdStatus { get; set; } = 0;

        [Description("MOD LOGS bot connection token.")]
        public string BotTokenModLogs { get; set; } = "";
        public string ChannelIdModLogs { get; set; } = "";
        public ulong GuildIdModLogs { get; set; } = 0;

        [Description("Server status embed id (set this if you've already started the server once and have a created embed, otherwise leave it at 0, start the server, then put the id of the embed message here).")]
        public ulong ServerStatusMessageId { get; set; } = 0;

        [Description("Anti mass-ban (the ban duration is in seconds).")]
        public int Maxbans { get; set; } = 5;
        public int DuratabanIssuer { get; set; } = 1576800000;

        [Description("Anti mass team-kill.")]
        public int MaxSecondsIntervalforTKs { get; set; } = 60;
        public int MaxTeamKills { get; set; } = 3;
        public int AttackerJailedTower { get; set; } = 2;

        [Description("Jail towers.")]
        public UnityEngine.Vector3 Tower1 { get; set; } = new UnityEngine.Vector3(39.994f, 314.112f, -32.593f);
        public UnityEngine.Vector3 Tower2 { get; set; } = new UnityEngine.Vector3(-15.684f, 314.461f, -31.430f);
        public UnityEngine.Vector3 Tower3 { get; set; } = new UnityEngine.Vector3(44.986f, 313.064f, -51.014f);

        [Description("Is the anti mass team-kill active?")]
        public bool AntiTKdimassa { get; set; } = true;

        [Description("List of players (put the Steam ID) ignored by the anti mass-ban check.")]
        public List<string> IgnoredStaffers { get; set; } = new List<string>()
        {
            "........@steam",
        };
    }
}
