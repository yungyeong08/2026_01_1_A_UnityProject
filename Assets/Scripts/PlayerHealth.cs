using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;

    public float invincibleTime = 1.0f;
    public bool isinvincible = false;


    void Start()
    {
        currentLives = maxLives;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            currentLives--;
            Destroy(other.gameObject);

            if(currentLives <= 0)
            {
                GameOver();
            }
        }
    }
    
    

    void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("RestarGame",3.0f);

    }

    void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    void Update()
    {
        
    }
}
