using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    // "is trigger" is checked to we have to use trigger, not collide
    void OnTriggerEnter() {
        gameManager.CompleteLevel();
    }
    
}
