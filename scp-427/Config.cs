using System.ComponentModel;
using Exiled.API.Interfaces;
using Scp914;
using UnityEngine;

namespace scp_427
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enables debug logs.")]
        public bool Debug { get; set; } = false;

        [Description("SCP-427 lantern configuration.")]
        public Scp427Item Lantern { get; set; } = new Scp427Item();

        [Description("HP healed on every tick while the lantern is lit.")]
        public float HealAmountPerTick { get; set; } = 6f;

        [Description("Interval in seconds between one heal/immunity/accumulation tick and the next.")]
        public float TickIntervalSeconds { get; set; } = 0.5f;

        [Description("Cumulative seconds of use (lantern lit, doesn't reset by turning it off) before transforming into SCP-427-1.")]
        public float TransformThresholdSeconds { get; set; } = 240f;

        [Description("Max HP of SCP-427-1.")]
        public int TransformedMaxHealth { get; set; } = 2500;

        [Description("Scale (X, Y, Z size) of SCP-427-1.")]
        public Vector3 TransformedScale { get; set; } = new Vector3(1.3f, 1.2f, 1.3f);

        [Description("Additional movement speed percentage of SCP-427-1 (MovementBoost effect).")]
        public byte TransformedMovementBoostPercent { get; set; } = 50;

        [Description("Intensity of SCP-427-1's BodyshotReduction effect (value 4 = about 15% body-hit damage reduction).")]
        public byte TransformedBodyshotReductionIntensity { get; set; } = 4;

        [Description("Intensity of SCP-427-1's DamageReduction effect (value 120 = about 60% overall damage reduction).")]
        public byte TransformedDamageReductionIntensity { get; set; } = 120;

        [Description("Radius (meters) within which SCP-427-1 automatically forces open nearby bulk gates (Gate A/B, SCP-173's gate, SCP-914's door).")]
        public float GatePryRadius { get; set; } = 3f;

        [Description("Interval in seconds between checks to force open gates near SCP-427-1.")]
        public float GatePryCheckIntervalSeconds { get; set; } = 1f;

        [Description("SCP-914 knob setting required to convert SCP-500 into SCP-427.")]
        public Scp914KnobSetting Scp914RequiredKnobSetting { get; set; } = Scp914KnobSetting.Fine;

        [Description("Probability (0-100) that a duplicated SCP-500/SCP-207 pedestal on the map gets replaced with SCP-427 at round start.")]
        public int LockerDuplicateReplaceChance { get; set; } = 100;
    }
}
