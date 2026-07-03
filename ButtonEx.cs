using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Button Ex")]
    internal class ButtonEx : Button
    {
        public ButtonClickedEvent onRightClick = new ButtonClickedEvent();
    }
}
