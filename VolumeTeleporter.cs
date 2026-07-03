using System.Collections;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Volume Teleporter")]
    public class VolumeTeleporter : MonoBehaviour
    {
        public string achievement;

        public Transform target;

        public ushort teleportEffect;

        public Transform effectHook;
    }
}
