using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Scroll Rect Ex")]
    internal class ScrollRectEx : ScrollRect
    {
        [SerializeField]
        public bool HandleScrollWheel = true;
    }
}
