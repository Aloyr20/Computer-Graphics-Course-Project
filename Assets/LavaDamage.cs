using UnityEngine;

public class LavaDamage : MonoBehaviour
{
   
    public int damagePerSecond = 10; 

    private void OnTriggerStay(Collider other)
    {
        PlayerHealth health = other.GetComponent<PlayerHealth>();

        EnemyHP enemy = other.GetComponent<EnemyHP>();

        if (health != null)
        {
            health.TakeDamage(Mathf.RoundToInt(damagePerSecond * Time.deltaTime));
        }

        if (enemy != null)
        {
            enemy.TakeDamage(Mathf.RoundToInt(damagePerSecond * Time.deltaTime));
        }
    }
}
