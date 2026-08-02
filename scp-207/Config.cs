using System.ComponentModel;
using Exiled.API.Interfaces;

namespace scp_207
{
    public class Config : IConfig
    {
        [Description("Determines whether the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Determines whether debug messages are displayed.")]
        public bool Debug { get; set; } = false;

        [Description("Seconds before the grenade explodes after drinking SCP-207.")]
        public float ExplosionFuseTime { get; set; } = 0.1f;
    }
}