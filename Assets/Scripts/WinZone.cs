using UnityEngine;

public class WinZone : MonoBehaviour
{
    Rigidbody rb;
    public LevelClearController levelClearController;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelClearController.Win();
        }
    }
}
