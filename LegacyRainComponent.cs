using UnityEngine;

namespace SDG.Unturned
{
    [AddComponentMenu("Unturned Scripts/Legacy Rain Component")]
    public class LegacyRainComponent : MonoBehaviour
    {
        // --- Inherited Members ---

        public float globalBlendAlpha;

        public float localVolumeBlendAlpha;

        public bool isWeatherActive;

        public bool hasTickedBlending;

        public bool isFullyTransitionedIn;

        public Color fogColor;

        public float fogDensity;

        public bool overrideFog;

        public bool overrideAtmosphericFog;

        public bool overrideCloudColors;

        public Color cloudColor;

        public Color cloudRimColor;

        public float puddleWaterLevel;

        public float puddleIntensity;

        public float brightnessMultiplier = 1f;

        public float shadowStrengthMultiplier = 1f;

        public float fogBlendExponent = 1f;

        public float cloudBlendExponent = 1f;

        public float windMain;

        public AudioSource ambientAudioSource;
    }
}
