using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace Welcome
{
    public class WelcomePlugin : Plugin<Config>
    {
        public override string Name => "Welcome";

        public override string Author => "Occhiofly";

        public override Version Version => new Version(1, 0, 0);

        public static WelcomePlugin Instance;

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.Verified += OnVerified;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            Exiled.Events.Handlers.Player.Verified -= OnVerified;
            base.OnDisabled();
        }

        private void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(10, "Welcome to the server!");
        }
    }
}