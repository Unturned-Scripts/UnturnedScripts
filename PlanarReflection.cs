using SDG.Unturned;
using UnityEngine;

[AddComponentMenu("Unturned Scripts/Planar Reflection")]
public class PlanarReflection : MonoBehaviour
{
    public LayerMask reflectionMask;

    public bool reflectSkybox;

    public Color clearColor = Color.grey;

    public string reflectionSampler = "_ReflectionTex";

    public float clipPlaneOffset = 0.07f;

    public Material sharedMaterial;
}
