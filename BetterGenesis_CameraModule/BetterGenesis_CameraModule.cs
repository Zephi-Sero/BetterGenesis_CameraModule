using System;
using System.Collections.Generic;
using System.Linq;
using TheGenesisProjectModPatcher;
using TheGenesisProjectModPatcher.Mod;
using TheGenesisProjectModPatcher.Mod.Event;
using UnityEngine;

namespace BetterGenesis_CameraModule {
    public class BetterGenesis_CameraModule : TGPMod {
        public override string ModName => "BetterGenesis_CameraModule";
        public override string ModVersion => "1.1";
        public override string ModAuthor => "zephyrouSerotonin";
        private static readonly List<string> loadafter = new List<string>();
        private static readonly List<string> modtags = new List<string>(new string[] {"camera"});
        public override Pair<string, string>[] Dependencies => new Pair<string, string>[] {
            new Pair<string,string>("TheGenesisProjectModPatcher","[0.2.0,0.3.0)"),
        };
        internal static GameObject camcontrol_go;

        public override void PatchMod() {
            ModPatcher.AddEventListener(new OnWorldManagerCreated(this));
            ModPatcher.AddEventListener(new QuitGameEvent(this));
        }
    }
}
