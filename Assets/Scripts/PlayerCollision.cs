using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            if(SettingsMenu.vibrationActivated == true)
                Handheld.Vibrate();
            ++PlayerControls.ad;
            if(PlayerControls.sceneIndex == 3)
                ++PlayerControls.deathCount2;
            else if(PlayerControls.sceneIndex == 4)
                ++PlayerControls.deathCount3;
            GetComponent<PlayerControls>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
