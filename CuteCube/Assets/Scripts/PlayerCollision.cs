using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // reference to another script
    public PlayerMovement movement;

    // a built-in method that runs whenever the object collides with something
    void OnCollisionEnter(Collision collisionInfo) {
        
        // this will stop the object from moving after colliding with an obstacle tagged "obstacle"
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;

             // will be used to end the game, similar to GetComponent<>()
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
