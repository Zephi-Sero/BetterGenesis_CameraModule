using System;
using System.Linq;
using TheGenesisProjectModPatcher;
using TheGenesisProjectModPatcher.Mod;
using TheGenesisProjectModPatcher.Mod.Event;
using UnityEngine;

namespace BetterGenesis_CameraModule {
    public class BetterGenesis_CameraModule : TGPMod {
        public override string ModName => "BetterGenesis_CameraModule";

        public override Version ModVersion => new Version("1.0");

        public override string ModAuthor => "zephyrouSerotonin";

        internal static GameObject camcontrol_go;
        public override void AfterPatch() {}
        public override void BeforePatch() {
            ModPatcher.AddEventListener(new OnWorldManagerCreated(this));
            ModPatcher.AddEventListener(new QuitGameEvent(this));
        }
    }
}
