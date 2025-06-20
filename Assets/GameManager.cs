using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float RestartDelay = 1.5f;

    public GameObject CompleteLevelUI;
    
    public  void CompletedLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame()

    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over!");

            // restart game

            Invoke("Restart", RestartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
