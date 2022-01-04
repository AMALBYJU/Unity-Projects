using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject LevelCompletePanel;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void LevelComplete()
    {
        Debug.Log("Level Complete");
        LevelCompletePanel.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
