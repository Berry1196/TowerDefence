
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameHasEnded;
    public GameObject gameOverUI;
    Player player;
    void Start()
    {
        gameHasEnded = false;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameHasEnded)
        {
            return;
        }
        if (player.currentHealth <= 0)
        {
            gameHasEnded = true;
            EndGame();
        }
        /* if (Input.GetKeyDown("e"))
         {
             EndGame();
         } */
    }



    void EndGame()
    {
        gameHasEnded = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
