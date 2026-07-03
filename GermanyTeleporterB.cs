using System;
using System.Collections;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Germany TeleporterB")]
    public class GermanyTeleporterB : MonoBehaviour
    {
        public float sqrBossRadius;

        public int navIndex;

        // --- Inherited Members ---

        public Transform target;

        public float sqrRadius;

        public string eventID;

        public ushort teleportEffect;
    }
}
