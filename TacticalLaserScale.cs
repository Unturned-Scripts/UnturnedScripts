using System;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Tactical Laser Scale")]
    public class TacticalLaserScale : MonoBehaviour
    {
        public float scaleMultiplier = 0.1f;

        public AnimationCurve scalingCurve;

        public void OnWillRenderObject()
        {
        }
    }
}
