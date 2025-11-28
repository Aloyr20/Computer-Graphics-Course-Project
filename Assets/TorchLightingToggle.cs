using UnityEngine;

public class TorchLightingController : MonoBehaviour
{
    private Light[] torchLights;
    public bool lightsOn = true;

    void Start()
    {
        torchLights = FindObjectsOfType<Light>();
    }

    public void ToggleTorches(bool enable)
    {
        lightsOn = enable;

        foreach (var light in torchLights)
            light.enabled = enable;
    }

    public void ToggleSwitch()
    {
        lightsOn = !lightsOn;

        foreach (var light in torchLights)
            light.enabled = lightsOn;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            ToggleSwitch();
    }
}
