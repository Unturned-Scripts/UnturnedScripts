using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Germany TeleporterA")]
    public class GermanyTeleporterA : MonoBehaviour
    {
        public Transform target;

        public float sqrRadius;

        public string eventID;

        public ushort teleportEffect;
    }
}
