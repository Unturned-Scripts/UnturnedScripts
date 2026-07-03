using System;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Nodes/Airdrop Devkit Node")]
    public class AirdropDevkitNode : MonoBehaviour
    {
        [Obsolete("Replaced by CargoSpawnTableRef")]
        public ushort id;

        [SerializeField]
        internal Guid _cargoSpawnTableGuid;

        [SerializeField]
        private BoxCollider boxCollider;

        // --- Inherited Members ---

        public bool isSelected;
    }
}
