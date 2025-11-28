using UnityEngine;

public class LevelClearController : MonoBehaviour
{
    public int totalEnemiesWave1;
    public int totalEnemiesWave2;
    int enemiesKilled;
    int wave = 1;
    public GameObject Wave2Skeletons;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public LutController lutController;
    public SlopeController slopeController;
    public Material orbMaterial;

    private void Start()
    {
        Wave2Skeletons.SetActive(false);

        WinScreen.SetActive(false);
        LoseScreen.SetActive(false);

        orbMaterial.SetFloat(Shader.PropertyToID("_Wave1Complete"), 0.0f);
    }

    void Update()
    {
        if (wave == 1)
        {
            if (enemiesKilled == totalEnemiesWave1)
            {
                Wave1Complete();
            }
        }
        else if (wave == 2)
        {
            if (enemiesKilled == totalEnemiesWave2)
            {
                Wave2Complete();
            }
        }
    }

    public void EnemyKilled()
    {
        enemiesKilled++;
    }

    void Wave1Complete()
    {
        Debug.Log("Wave 1 complete");
        enemiesKilled = 0;
        wave = 2;

        lutController.SetHorror();

        slopeController.slopeActive = true;

        orbMaterial.SetFloat(Shader.PropertyToID("_Wave1Complete"), 1.0f);

        Wave2Skeletons.SetActive(true);

        // Enable custom LUT and orb stencil shader
    }

    void Wave2Complete()
    {
        Debug.Log("Wave 2 complete");
        enemiesKilled = 0;

        lutController.SetOff();

        slopeController.slopeActive = false;

        //Win();
    }

    public void Win()
    {
        Time.timeScale = 0f;
        WinScreen.SetActive(true);
    }

    public void Lose()
    {
        Time.timeScale = 0f;
        LoseScreen.SetActive(true);
    }
}
