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
    internal class OnWorldManagerCreated : EventListener {
        public OnWorldManagerCreated(TGPMod mod) : base(mod) {
            listeningFor = new Type[] { typeof(WorldManagerCreatedEvent) }.ToList();
        }
        public override bool OnEvent(IGameEvent evt) {
            BetterGenesis_CameraModule.camcontrol_go = new GameObject("BetterGenesis_CamController", typeof(BetterCameraController));
            return true;
        }
    }
}
