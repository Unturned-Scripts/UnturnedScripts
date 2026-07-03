using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Zombie Boss Quest")]
    public class ZombieBossQuest : MonoBehaviour
    {
        public Transform target;

        public float sqrRadius;

        public ushort teleportEffect;
    }
}
