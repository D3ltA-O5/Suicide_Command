using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using CommandSystem;
using RemoteAdmin;

namespace CommandItemGiver
{
    public class CommandItemGiverPlugin : Plugin<Config>
    {
        public override string Name => "Suicide_Plugin";
        public override string Author => "D3ltA_O5";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        public static CommandItemGiverPlugin Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();
            Log.Info("Suicide_Plugin has been successfully enabled.");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Log.Info("Suicide_Plugin has been successfully disabled.");
        }
    }
}
