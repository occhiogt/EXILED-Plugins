using System;
using Exiled.API.Features;

namespace ScpHealth
{
    public class ScpHealthPlugin : Plugin<Config>
    {
        public static ScpHealthPlugin Instance { get; private set; }

        public override string Name => "ScpHealth";
        public override string Author => "Occhiofly";
        public override string Prefix => "scphealth";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 14, 2);

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;

            eventHandlers = new EventHandlers(Config);
            eventHandlers.Register();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            eventHandlers?.Unregister();
            eventHandlers = null;

            Instance = null;
            base.OnDisabled();
        }
    }
}