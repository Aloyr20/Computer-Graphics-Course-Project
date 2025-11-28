using UnityEngine;

public class OrbGiveHP : MonoBehaviour
{
    Rigidbody rb;
    public PlayerHealth playerHealth;
    bool gaveHP;
    public int hpAmount;
    public Material orbMaterial;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        orbMaterial.SetFloat(Shader.PropertyToID("_GotHP"), 0.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!gaveHP)
            {
                gaveHP = true;
                playerHealth.GiveHP(hpAmount);
                orbMaterial.SetFloat(Shader.PropertyToID("_GotHP"), 1.0f);
            }
        }
    }
}
