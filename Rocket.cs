using System;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Rocket")]
    public class Rocket : MonoBehaviour
    {
        public float range;

        public float playerDamage;

        public float zombieDamage;

        public float animalDamage;

        public float barricadeDamage;

        public float structureDamage;

        public float vehicleDamage;

        public float resourceDamage;

        public float objectDamage;

        public Guid explosionEffectGuid;

        public ushort explosion;

        public bool penetrateBuildables;

        public Transform ignoreTransform;

        public ERagdollEffect ragdollEffect;

        public float explosionLaunchSpeed;
    }
}
