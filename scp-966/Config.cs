using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace scp_966
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Shows debug messages in the console.")]
        public bool Debug { get; set; } = false;

        [Description("Minimum connected players for the first SCP-966 to be able to spawn.")]
        public int MinPlayersFirst { get; set; } = 20;

        [Description("Percentage chance that the first SCP-966 spawns.")]
        public int FirstSpawnChance { get; set; } = 35;

        [Description("Minimum players for a second SCP-966 to also be able to spawn (rolled only if the first one spawned).")]
        public int MinPlayersSecond { get; set; } = 30;

        [Description("Percentage chance that the second SCP-966 spawns (additional, never replaces other SCPs).")]
        public int SecondSpawnChance { get; set; } = 50;

        [Description("From this player count upward, no SCP-966 replaces another SCP: all of them are additional.")]
        public int MinPlayersNoReplace { get; set; } = 40;

        [Description("SCP roles that the first SCP-966 can replace (below the MinPlayersNoReplace threshold).")]
        public List<RoleTypeId> ReplaceableScpRoles { get; set; } = new List<RoleTypeId>
        {
            RoleTypeId.Scp049,
            RoleTypeId.Scp096,
            RoleTypeId.Scp106,
            RoleTypeId.Scp173,
            RoleTypeId.Scp939,
        };

        [Description("Roles from which players are picked to be converted into additional SCP-966s (that don't replace an SCP).")]
        public List<RoleTypeId> SpawnCandidateRoles { get; set; } = new List<RoleTypeId>
        {
            RoleTypeId.ClassD
        };

        [Description("Spawn rooms in order of preference (the old 939 test room first).")]
        public List<RoomType> SpawnRooms { get; set; } = new List<RoomType>
        {
            RoomType.HczTestRoom,
            RoomType.Hcz939
        };

        [Description("Seconds to wait after round start before converting into SCP-966.")]
        public float SpawnDelay { get; set; } = 2f;

        [Description("SCP-966's HP.")]
        public float Hp { get; set; } = 1200f;

        [Description("Maximum Hume Shield obtainable by eating corpses.")]
        public float MaxShield { get; set; } = 600f;

        [Description("Hume Shield gained per corpse eaten at full health.")]
        public float ShieldPerCorpse { get; set; } = 75f;

        [Description("HP healed per corpse eaten (100 = vanilla).")]
        public float ConsumeHeal { get; set; } = 100f;

        [Description("Vertical model scale (1 = normal height, 1.08 = slightly taller).")]
        public float HeightScale { get; set; } = 1.08f;

        [Description("Claw (M1) damage.")]
        public float ClawDamage { get; set; } = 18f;

        [Description("Speed boost percentage while SCP-966 is revealed from taking damage (counterattack).")]
        public byte CounterAttackBoostPercent { get; set; } = 35;

        [Description("Seconds of visibility after taking damage.")]
        public float RevealDuration { get; set; } = 4f;

        [Description("Seconds of visibility after attacking with the claw.")]
        public float AttackRevealDuration { get; set; } = 0.6f;

        [Description("Maximum distance at which SCPs can see an invisible SCP-966.")]
        public float ScpViewDistance { get; set; } = 80f;

        [Description("Enables the Waves aura.")]
        public bool WavesEnabled { get; set; } = true;

        [Description("Radius in meters of the Waves aura.")]
        public float WavesRadius { get; set; } = 6f;

        [Description("Seconds between one aura tick and the next.")]
        public float WavesTickSeconds { get; set; } = 3f;

        [Description("Slowness stacks (1 stack = 1%) added per tick to whoever is inside the aura.")]
        public byte WavesStacksPerTick { get; set; } = 5;

        [Description("Maximum cap of Slowness stacks that can be accumulated.")]
        public byte WavesMaxStacks { get; set; } = 90;

        [Description("Seconds of the Scanned effect applied on every slowness increase.")]
        public float ScannedDuration { get; set; } = 3.5f;

        [Description("Stacks at which permanent Amnesia Items and Amnesia Vision trigger.")]
        public byte AmnesiaThreshold { get; set; } = 50;

        [Description("Stacks at which permanent Blurriness and Deafened trigger.")]
        public byte BlurThreshold { get; set; } = 75;

        [Description("Enables the scanner sound emitted by the Waves aura.")]
        public bool WavesAudioEnabled { get; set; } = true;

        [Description("Audio file for the Waves sound (.ogg mono 48kHz). If it's not an absolute path, it's looked up in EXILED's config folders.")]
        public string WavesAudioFile { get; set; } = "Scanner_Scanning.ogg";

        [Description("Volume of the Waves sound (0-1).")]
        public float WavesAudioVolume { get; set; } = 0.8f;

        [Description("Maximum distance in meters at which the Waves sound can be heard.")]
        public float WavesAudioRange { get; set; } = 10f;

        [Description("Hint shown to the player converted into SCP-966.")]
        public string SpawnHint { get; set; } =
            "<color=red>You are SCP-966!</color>\n" +
            "You are <b>invisible</b> to humans but visible to SCPs.\n" +
            "If you take damage you'll be revealed for a few seconds.\n" +
            "Eat corpses to heal, and at full health, to build up shield.";

        [Description("Broadcast to everyone when at least one SCP-966 spawns (empty = no broadcast).")]
        public string SpawnBroadcast { get; set; } = "";
    }
}
