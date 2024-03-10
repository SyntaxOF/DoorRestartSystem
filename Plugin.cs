using DoorRestartSystem.Events;
using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorRestartSystem
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; } = null!;
        public override string Name => "DoorRestartSystem";
        public override string Author => "syntax_.os";
        public override Version RequiredExiledVersion => new Version(13, 4, 2);
        public override Version Version => new Version(1, 0, 0);
        public override PluginPriority Priority { get; } = PluginPriority.Low;

        private RoundHandler roundHandler;
        public override void OnEnabled()
        {
            Instance = this;
            roundHandler = new RoundHandler();
            Exiled.Events.Handlers.Server.RoundStarted += roundHandler.RoundStart;
            Exiled.Events.Handlers.Server.RoundEnded += roundHandler.RoundEnd;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= roundHandler.RoundStart;
            Exiled.Events.Handlers.Server.RoundEnded -= roundHandler.RoundEnd;
            Instance = null!;
            base.OnDisabled();
        }
    }
}
