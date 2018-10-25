using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Text highScore;
    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text deathCountTXT;
    public Text deathCountTXT1;
    public Text deathCountTXT2;
    public Text deathCountTXT3;
    public static int number;
    public int sceneIndex;

    // Use this for initialization
    void Start () {
        if (sceneIndex == 0)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            deathCountTXT.text = PlayerPrefs.GetInt("DeathCountTXT", 0).ToString();
        }
        else if (sceneIndex == 1)
        {
            highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
            deathCountTXT1.text = PlayerPrefs.GetInt("DeathCountTXT1", 0).ToString();
        }
        else if (sceneIndex == 2)
        {
            highScore2.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
            deathCountTXT2.text = PlayerPrefs.GetInt("DeathCountTXT2", 0).ToString();
        }
        else if (sceneIndex == 3)
        {
            highScore3.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
            deathCountTXT3.text = PlayerPrefs.GetInt("DeathCountTXT3", 0).ToString();
        }
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = (player.position.x + 4.35).ToString("0");
        number = (int)(player.position.x + 4.35);
        if (sceneIndex == 0 && number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }
        else if (sceneIndex == 1 && number > PlayerPrefs.GetInt("HighScore1", 0))
        {
            PlayerPrefs.SetInt("HighScore1", number);
            highScore1.text = number.ToString();
        }
        else if (sceneIndex == 2 && number > PlayerPrefs.GetInt("HighScore2", 0))
        {
            PlayerPrefs.SetInt("HighScore2", number);
            highScore2.text = number.ToString();
        }
        else if (sceneIndex == 3 && number > PlayerPrefs.GetInt("HighScore3", 0))
        {
            PlayerPrefs.SetInt("HighScore3", number);
            highScore3.text = number.ToString();
        }
        if (sceneIndex == 0)
        {
            PlayerPrefs.SetInt("DeathCountTXT", PlayerControls.deathCount);
            deathCountTXT.text = PlayerControls.deathCount.ToString();
        }
        else if (sceneIndex == 1)
        {
            PlayerPrefs.SetInt("DeathCountTXT1", PlayerControls.deathCount1);
            deathCountTXT1.text = PlayerControls.deathCount1.ToString();
        }
        else if (sceneIndex == 2)
        {
            PlayerPrefs.SetInt("DeathCountTXT2", PlayerControls.deathCount2);
            deathCountTXT2.text = PlayerControls.deathCount2.ToString();
        }
        else if (sceneIndex == 3)
        {
            PlayerPrefs.SetInt("DeathCountTXT3", PlayerControls.deathCount3);
            deathCountTXT3.text = PlayerControls.deathCount3.ToString();
        }
    }

    public void Reset()
    {
        if (!PauseMenu.GameIsPaused)
        {
            Time.timeScale = 0f;
            PauseMenu.GameIsPaused = true;
            PlayerPrefs.DeleteAll();
            if (sceneIndex == 0)
                highScore.text = "0";
            else if (sceneIndex == 1)
                highScore1.text = "0";
            else if (sceneIndex == 2)
                highScore2.text = "0";
            else if (sceneIndex == 3)
                highScore3.text = "0";
            Time.timeScale = 1f;
            Invoke("GameIsPausedToFalse", 0.0000000000000001f);
        }
        else
        {
            PlayerPrefs.DeleteAll();
            if (sceneIndex == 0)
                highScore.text = "0";
            else if (sceneIndex == 1)
                highScore1.text = "0";
            else if (sceneIndex == 2)
                highScore2.text = "0";
            else if (sceneIndex == 3)
                highScore3.text = "0";
        }
    }

    public void GameIsPausedToFalse()
    {
        PauseMenu.GameIsPaused = false;
    }
}
