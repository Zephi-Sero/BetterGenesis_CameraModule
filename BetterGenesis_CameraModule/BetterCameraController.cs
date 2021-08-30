using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGenesisProjectModPatcher.PlayerControl;
using UnityEngine;

namespace BetterGenesis_CameraModule {
    class BetterCameraController : MonoBehaviour {
        public void Update() {
            float dAngle = 90f;
            if(Input.GetKey(KeyCode.LeftShift)) {
                dAngle /= 2;
            }
            if(Input.GetKey(KeyCode.LeftControl)) {
                dAngle /= 3;
            }
            PCamera.SetAngleInterval(dAngle);
        }
    }
}
