using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // Transform is used to find the position properties of the object
    // Vector3 is used to store 3 floats
    public Transform player;
    public Vector3 offset;

    void Update() {

        // used to let the camera follow the object (offset makes it in 3rd person)
        transform.position = player.position + offset;
    }

}
