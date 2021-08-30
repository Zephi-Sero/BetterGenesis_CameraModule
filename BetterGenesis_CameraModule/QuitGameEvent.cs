using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGenesisProjectModPatcher;
using TheGenesisProjectModPatcher.Mod;
using TheGenesisProjectModPatcher.Mod.Event;
using UnityEngine;

namespace BetterGenesis_CameraModule {
    internal class QuitGameEvent : EventListener {
        public QuitGameEvent(TGPMod mod) : base(mod) {
            listeningFor = new Type[] { typeof(QuitToMenuEvent) }.ToList();
        }
        public override bool OnEvent(IGameEvent evt) {
            UnityEngine.Object.Destroy(BetterGenesis_CameraModule.camcontrol_go);
            return true;
        }
    }
}
