using System;
using UnityEngine;
using UnityEngine.UI;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Web Image")]
    public class WebImage : MonoBehaviour
    {
        public Image targetImage;

        public string url;

        public bool shouldCache = true;

        public void Refresh()
        {
        }
    }
}
