using System.Collections;
using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Flashbang")]
    public class Flashbang : MonoBehaviour, IExplodableThrowable
    {
        public Color color = Color.white;

        public float fuseLength = 2.5f;

        public bool playAudioSource = true;

        public void Explode()
        {
        }
    }
}
