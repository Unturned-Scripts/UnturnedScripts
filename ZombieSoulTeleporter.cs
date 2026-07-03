using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Zombie Soul Teleporter")]
    public class ZombieSoulTeleporter : MonoBehaviour
    {
        public Transform target;

        public Transform targetBoss;

        public float sqrRadius;

        public byte soulsNeeded;

        public ushort collectEffect;

        public ushort teleportEffect;
    }
}
