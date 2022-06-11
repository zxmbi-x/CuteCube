using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // this is the component that we are editing
    public Rigidbody rb;

    // f is added to signify that this is a float, not a double
    public float forwardForce = 4000f;
    public float sideForce = 100f; 


    // runs when the game starts, called only once
    void Start() {

    }

    // called once per frame, used to perform changes midgame
    // usually called void Update(), but it's better to use FixedUpdte() for physics stuff
    void FixedUpdate() {

        // Adds a continuous moving force to the object
        // Multipluing by Time.deltaTime is used to even out the different FPS on different PCs
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // only executed if condition is met; in this case, if the user presses d
        if (Input.GetKey("d")) {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

}
