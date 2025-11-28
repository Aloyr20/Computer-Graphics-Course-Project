using UnityEngine;

public class SlopeController : MonoBehaviour
{
    public bool slopeActive;
    public Material slopeMaterial;
    public float rampForceMultiplier;

    void Update()
    {
        if (slopeActive)
        {
            slopeMaterial.SetFloat(Shader.PropertyToID("_SlopeActive"), 1.0f);
        }
        else
        {
            slopeMaterial.SetFloat(Shader.PropertyToID("_SlopeActive"), 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            slopeActive = !slopeActive;
        }
    }
}
