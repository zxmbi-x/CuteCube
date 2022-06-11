using UnityEngine;
using UnityEngine.SceneManagement; // to change the scene to level 2

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
