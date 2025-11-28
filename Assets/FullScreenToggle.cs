using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FullscreenPassController : MonoBehaviour
{
    public ScriptableRendererData rendererData;
    public int pixelFeatureIndex = 1;
    public int ditherFeatureIndex = 2;

    void FullScreenRenderFeatures(int index, bool enable)
    {
        var features = rendererData.rendererFeatures;

        if (index < 0 || index >= features.Count)
            return;

        var feature = features[index];
        if (feature != null)
            feature.SetActive(enable);

#if UNITY_EDITOR
        UnityEditor.EditorUtility.SetDirty(rendererData);
#endif
    }

    public void TogglePixel(bool enable)
    {
        FullScreenRenderFeatures(pixelFeatureIndex, enable);
    }

    public void ToggleDither(bool enable)
    {
        FullScreenRenderFeatures(ditherFeatureIndex, enable);
    }

    public void SwitchToPixel()
    {
        TogglePixel(true);
        ToggleDither(false);
    }

    public void SwitchToDither()
    {
        TogglePixel(false);
        ToggleDither(true);
    }

    public void SwitchToBoth()
    {
        TogglePixel(true);
        ToggleDither(true);
    }

    public void DisableAll()
    {
        TogglePixel(false);
        ToggleDither(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4)) SwitchToPixel();
        if (Input.GetKeyDown(KeyCode.Alpha5)) SwitchToDither();
        if (Input.GetKeyDown(KeyCode.Alpha6)) SwitchToBoth();
        if (Input.GetKeyDown(KeyCode.Alpha0)) DisableAll();
    }
}
