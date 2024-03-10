using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorRestartSystem
{
    public sealed class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages will be shown")]
        public bool Debug { get; set; } = false;

        [Description("When the first cycle can start after the round started (in seconds)")]
        public int FirstCycle { get; set; } = 60;

        [Description("First intervall when the next cycle can occur (in seconds)")]
        public int FirstInterval { get; set; } = 180;

        [Description("Second intervall when the next cycle can occur (in seconds)")]
        public int LastInterval { get; set; } = 300;

        [Description("How long the lockdown should last (in seconds)")]
        public int LockdownDuration { get; set; } = 50;

        [Description("How many times a cycle can occur in one round (0 = infinite)")]
        public int CyclesCount { get; set; } = 1;

        [Description("The cassie message that should be played when the lockdown starts")]
        public string CassieMessageStart { get; set; } = "pitch_0.3 .g4 .g4 pitch_1.00 Attention all Personnel . Door malfunction detected . Lockdown activated";

        [Description("The cassie message that should be played when the lockdowns ends")]
        public string CassieMessageEnd { get; set; } = "pitch_0.35 .g5 pitch_1.00 Lockdown deactivated . Door controls back online";
    }
}
