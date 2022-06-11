using UnityEngine;

// to work with UI elements
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;

    // to adjust the text of type Text
    public Text score;
    
    void Update() {

        // setting its value to player's z-axis position, changing from float to String, 0 indicates that we only want whole numbers
        score.text = player.position.z.ToString("0"); 

    }

}
