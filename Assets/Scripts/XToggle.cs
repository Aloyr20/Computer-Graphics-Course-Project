using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class XToggle : MonoBehaviour
{
    public Material normalMat;
    public Material xrayMat;

    bool usedXray;

    public float durationInSeconds = 3f;

    SkinnedMeshRenderer skinnedMeshRenderer;

    private void Start()
    {
        skinnedMeshRenderer = transform.GetChild(1).GetChild(1).gameObject.GetComponent<SkinnedMeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!usedXray)
            {
                StartCoroutine(EnableXray());
            }
        }
    }

    public IEnumerator EnableXray()
    {
        usedXray = true;

        normalMat = skinnedMeshRenderer.material;
        skinnedMeshRenderer.material = xrayMat;

        yield return new WaitForSeconds(durationInSeconds);

        skinnedMeshRenderer.material = normalMat;
    }
}
