using System;
using System.Collections.Generic;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Zombie Soul Flag")]
    public class ZombieSoulFlag : MonoBehaviour
    {
        public ushort flagPlaced;

        public ushort flagKills;

        public float sqrRadius;

        public byte soulsNeeded;

        public ushort collectEffect;

        public ushort teleportEffect;
    }
}
