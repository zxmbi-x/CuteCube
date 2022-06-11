using UnityEngine;
using UnityEngine.SceneManagement;      // used to restart the game

public class GameManager : MonoBehaviour
{

    bool ended = false;
    public float delay = 1f;
    public GameObject completeLevelUI;

    // so that our end screen appears
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (ended == false)
        {
            ended = true;
            Invoke("Restart", delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
