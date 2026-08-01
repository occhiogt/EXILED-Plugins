using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups.Projectiles;
using Exiled.Events.EventArgs.Player;

namespace scp_018
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
            Exiled.Events.Handlers.Player.ThrownProjectile += OnThrownProjectile;
        }

        public void Unregister()
        {
            Exiled.Events.Handlers.Player.ThrownProjectile -= OnThrownProjectile;
        }

        private void OnThrownProjectile(ThrownProjectileEventArgs ev)
        {
            if (!(ev.Projectile is Scp018Projectile ball))
                return;

            ball.FuseTime = config.Time;

            if (config.Debug)
                Log.Info($"[scp018] {ev.Player?.Nickname}'s ball: will explode in {config.Time} seconds.");
        }
    }
}