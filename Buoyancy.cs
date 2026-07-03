using System.Collections.Generic;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Buoyancy")]
    public class Buoyancy : MonoBehaviour
    {
        public float density = 500f;

        public int slicesPerAxis = 2;

        public float overrideSurfaceElevation = -1f;
    }
}
