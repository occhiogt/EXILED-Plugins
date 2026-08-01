using System.ComponentModel;
using Exiled.API.Interfaces;

namespace scp_018
{
    public class Config : IConfig
    {
        [Description("Determines whether the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Determines whether debug messages are displayed.")]
        public bool Debug { get; set; } = false;

        [Description("Total seconds that SCP-018 bounces before exploding.")]
        public float Time { get; set; } = 300f;
    }
}