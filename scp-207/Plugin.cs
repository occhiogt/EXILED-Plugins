using System;
using Exiled.API.Features;

namespace scp_207
{
    public class Scp207Plugin : Plugin<Config>
    {
        public static Scp207Plugin Instance { get; private set; }

        public override string Name => "Scp_207";

        public override string Author => "Occhiofly";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(9, 14, 2);

        public EventHandlers Handlers { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            Handlers = new EventHandlers(Config);
            Handlers.Register();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Handlers?.Unregister();
            Handlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}