using Exiled.API.Features;
using Exiled.API.Features.Doors;
using Exiled.Events.EventArgs.Server;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorRestartSystem.Events
{
    internal sealed class RoundHandler
    {
        private Random random = new Random();
        private CoroutineHandle routine;
        private int count = 0;
        public void RoundStart()
        {
            routine = Timing.RunCoroutine(Restarter());
        }

        public void RoundEnd(RoundEndedEventArgs ev)
        {
            Timing.KillCoroutines(routine);
        }

        private IEnumerator<float> Restarter()
        {
            Timing.WaitForSeconds(Plugin.Instance.Config.FirstCycle);
            for (; ; )
            {
                if ((Plugin.Instance.Config.CyclesCount == 0) || (count < Plugin.Instance.Config.CyclesCount))
                {
                    yield return Timing.WaitForSeconds(random.Next(Plugin.Instance.Config.FirstInterval, Plugin.Instance.Config.LastInterval + 1));
                    Cassie.Message(Plugin.Instance.Config.CassieMessageStart);
                    foreach (Door door in Door.List)
                    {
                        door.IsOpen = false;
                        door.ChangeLock(Exiled.API.Enums.DoorLockType.Regular079);
                    }
                    yield return Timing.WaitForSeconds(Plugin.Instance.Config.LockdownDuration);
                    Cassie.Message(Plugin.Instance.Config.CassieMessageEnd);
                    foreach (Door door in Door.List)
                    {
                        door.ChangeLock(Exiled.API.Enums.DoorLockType.None);
                    }
                    count++;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}
