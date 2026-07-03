using SDG.Unturned;
using UnityEngine;

namespace SDG.Framework.Devkit
{
    [AddComponentMenu("Unturned Scripts/Nodes/Spawnpoint")]
    public class Spawnpoint : MonoBehaviour
    {
        [SerializeField]
        public string id;

        // --- Inherited Members ---

        public bool isSelected;
    }
}
