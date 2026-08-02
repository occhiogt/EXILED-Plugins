using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;

namespace scp_207
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
            Exiled.Events.Handlers.Player.UsedItem += OnUsedItem;
        }

        public void Unregister()
        {
            Exiled.Events.Handlers.Player.UsedItem -= OnUsedItem;
        }

        private void OnUsedItem(UsedItemEventArgs ev)
        {
            if (ev.Item.Type != ItemType.SCP207)
                return;

            if (Item.Create(ItemType.GrenadeHE) is ExplosiveGrenade grenade)
            {
                grenade.FuseTime = config.ExplosionFuseTime;
                grenade.SpawnActive(ev.Player.Position);
            }

            if (config.Debug)
                Log.Info($"[scp207] {ev.Player?.Nickname ?? "Unknown"} exploded after drinking SCP-207.");
        }
    }
}