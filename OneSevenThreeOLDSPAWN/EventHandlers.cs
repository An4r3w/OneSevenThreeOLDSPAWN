using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace OneSevenThreeESC
{
    public class EventHandlers
    {
        public void OnSpawned(SpawnedEventArgs ev)
        {
            if (ev.Player.Role == RoleTypeId.Scp173)
            {
                ev.Player.Position = Door.Get(DoorType.Scp173Gate).Position;
            }
        }
    }
}