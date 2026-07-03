using UnityEngine;

[AddComponentMenu("Unturned Scripts/Water Base")]
[ExecuteInEditMode]
public class WaterBase : MonoBehaviour
{
    public Material sharedMaterial;

    public WaterQuality waterQuality = WaterQuality.High;

    public bool edgeBlend = true;

    public void UpdateShader()
    {
    }
}
