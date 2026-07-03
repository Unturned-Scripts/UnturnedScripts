using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Nodes/Location Devkit Node")]
    public class LocationDevkitNode : MonoBehaviour
    {
        public string locationName;

        public bool isVisibleOnMap = true;

        [SerializeField]
        private BoxCollider boxCollider;

        // --- Inherited Members ---

        public bool isSelected;
    }
}
