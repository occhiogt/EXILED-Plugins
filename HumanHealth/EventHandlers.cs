using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace HumanHealth
{
    public class EventHandlers
    {
        private readonly Config config;

        public EventHandlers(Config config)
        {
            this.config = config;
        }

        public void Register()
        {
            Exiled.Events.Handlers.Player.Spawned += OnSpawned;
        }

        public void Unregister()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnSpawned;
        }

        private void OnSpawned(SpawnedEventArgs ev)
        {
            if (!config.CustomHp.TryGetValue(ev.Player.Role.Type, out float hp))
            {
                if (config.Debug)
                    Log.Info($"[humanhealth] {ev.Player.Nickname} ({ev.Player.Role.Type}): unmanaged role, vanilla HP.");

                return;
            }

            ev.Player.MaxHealth = hp;
            ev.Player.Health = hp;

            if (config.Debug)
                Log.Info($"[humanhealth] {ev.Player.Nickname} ({ev.Player.Role.Type}): HP set to {hp}.");
        }
    }
}