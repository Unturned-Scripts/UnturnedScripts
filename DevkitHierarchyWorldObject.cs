using UnityEngine;
using System;
using SDG.Unturned;

namespace SDG.Framework.Devkit
{
    [AddComponentMenu("Unturned Scripts/Devkit Hierarchy World Object")]
    [Obsolete]
    public class DevkitHierarchyWorldObject : MonoBehaviour
    {
        public int materialIndexOverride = -1;

        public Guid GUID;

        public ELevelObjectPlacementOrigin placementOrigin;
    }
}
