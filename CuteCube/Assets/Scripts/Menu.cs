using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
   
   public void StartGame() {

       // plays the next scene
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

}
