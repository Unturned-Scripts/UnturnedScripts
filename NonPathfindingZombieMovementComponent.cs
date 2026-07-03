using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Non Pathfinding Zombie Movement Component")]
    public class NonPathfindingZombieMovementComponent : MonoBehaviour
    {
        public bool canMove = true;

        public bool canTurn = true;

        public bool canSearch = true;

        public float speed;

        public Transform targetTransform;

        public Vector3 targetDirection;

        public void Move(float deltaTime)
        {
        }
    }
}
