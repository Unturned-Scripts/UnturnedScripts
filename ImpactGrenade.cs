using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Impact Grenade")]
    public class ImpactGrenade : MonoBehaviour
    {
        public IExplodableThrowable explodable;

        // --- Inherited Members ---

        public Transform ignoreTransform;
    }
}
