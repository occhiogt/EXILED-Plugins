using System.ComponentModel;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using PlayerRoles;

namespace ScpHealth
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Show debug messages in the console.")]
        public bool Debug { get; set; } = false;

        [Description("Custom HP for each SCP.")]
        public Dictionary<RoleTypeId, float> CustomHp { get; set; } = new Dictionary<RoleTypeId, float>
        {
            { RoleTypeId.Scp049, 1500f },
            { RoleTypeId.Scp0492, 1200f },
            { RoleTypeId.Scp096, 2000f },
            { RoleTypeId.Scp106, 2500f },
            { RoleTypeId.Scp173, 1800f },
            { RoleTypeId.Scp3114, 2200f },
            { RoleTypeId.Scp939, 2200f }
        };
    }
}