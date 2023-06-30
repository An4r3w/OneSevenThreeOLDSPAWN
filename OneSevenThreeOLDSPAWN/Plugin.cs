using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace OneSevenThreeESC
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;

        private EventHandlers events;

        public override string Author => "An4r3w";

        public override string Name { get; } = "PenautEasy";

        public override string Prefix { get; } = "ezpenaut";

        public override Version Version => new Version(3, 5, 0);

        public override Version RequiredExiledVersion => new Version(7, 0, 0);

        public override PluginPriority Priority => PluginPriority.Default;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Player.Spawned += events.OnSpawned;

            Singleton = this;
            events = new EventHandlers();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Player.Spawned -= events.OnSpawned;

            events = null;
        }
    }
}