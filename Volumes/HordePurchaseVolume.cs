using UnityEngine;

namespace SDG.Unturned
{
    // Volumes use the Scale of the GameObject as the Size for the Volume, No Colliders Required but you can still use one by Assigning your Collider to the volumeCollider field
    // This Volume Script should be attached to an Empty GameObject with Tag and Layer :: Trap
    // To Visualize the Size of the Volume Temporarily Attach either a BoxCollider or a SphereCollider. Making sure that the Collider Component uses the default Radius ( 0.5 ) or Size ( 1 1 1 )
    [AddComponentMenu("Unturned Scripts/Volumes/Horde Purchase Volume")]
    public class HordePurchaseVolume : MonoBehaviour
    {
        public ushort id;

        public uint cost;

        // --- Inherited Members ---

        [SerializeField]
        private ELevelVolumeShape _shape;

        public float falloffDistance;

        [SerializeField]
        internal Collider volumeCollider;

        [SerializeField]
        protected GameObject editorGameObject;

        [SerializeField]
        protected MeshFilter editorMeshFilter;

        [SerializeField]
        protected MeshRenderer editorMeshRenderer;
    }
}
