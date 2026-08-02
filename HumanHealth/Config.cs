using System.ComponentModel;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using PlayerRoles;

namespace HumanHealth
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Shows debug messages in the console.")]
        public bool Debug { get; set; } = false;

        [Description("Custom HP for each Human.")]
        public Dictionary<RoleTypeId, float> CustomHp { get; set; } = new Dictionary<RoleTypeId, float>
        {
            { RoleTypeId.ClassD, 100f },
            { RoleTypeId.Scientist, 100f },
            { RoleTypeId.FacilityGuard, 100f },
            { RoleTypeId.NtfCaptain, 100f },
            { RoleTypeId.NtfPrivate, 100f },
            { RoleTypeId.NtfSergeant, 100f },
            { RoleTypeId.NtfSpecialist, 100f },
            { RoleTypeId.ChaosConscript, 100f },
            { RoleTypeId.ChaosMarauder, 100f },
            { RoleTypeId.ChaosRepressor, 100f },
            { RoleTypeId.ChaosRifleman, 100f },
            { RoleTypeId.Tutorial, 100f  }
        };
    }
}