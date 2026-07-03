using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Decal")]
    public class Decal : MonoBehaviour
    {
        public EDecalType type;

        public Material material;

        public bool isSelected;

        public float lodBias = 1f;
    }
}
