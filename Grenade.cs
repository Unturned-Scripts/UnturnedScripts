using System;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Grenade")]
    public class Grenade : MonoBehaviour, IExplodableThrowable
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

        public float fuseLength = 2.5f;

        public float explosionLaunchSpeed;

        public bool shouldDestroySelf = true;

        public void Explode()
        {
        }
    }
}
