using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Text highScore;
    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;
    public Text highScore6;
    public Text highScore7;
    public Text deathCountTXT;
    public Text deathCountTXT1;
    public Text deathCountTXT2;
    public Text deathCountTXT3;
    public Text deathCountTXT4;
    public Text deathCountTXT5;
    public Text deathCountTXT6;
    public Text deathCountTXT7;
    public static int number;
    public static int hs;
    public static int hs1;
    public static int hs2;
    public static int hs3;
    public static int hs4;
    public static int hs5;
    public static int hs6;
    public static int hs7;
    public int sceneIndex;

    // Use this for initialization
    void Start () {
        if (sceneIndex == 0)
        {
            hs = PlayerPrefs.GetInt("HS", 0);
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            deathCountTXT.text = PlayerPrefs.GetInt("DeathCountTXT", 0).ToString();
        }
        else if (sceneIndex == 1)
        {
            hs1 = PlayerPrefs.GetInt("HS1", 0);
            highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
            deathCountTXT1.text = PlayerPrefs.GetInt("DeathCountTXT1", 0).ToString();
        }
        else if (sceneIndex == 2)
        {
            hs2 = PlayerPrefs.GetInt("HS2", 0);
            highScore2.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
            deathCountTXT2.text = PlayerPrefs.GetInt("DeathCountTXT2", 0).ToString();
        }
        else if (sceneIndex == 3)
        {
            hs3 = PlayerPrefs.GetInt("HS3", 0);
            highScore3.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
            deathCountTXT3.text = PlayerPrefs.GetInt("DeathCountTXT3", 0).ToString();
        }
        else if (sceneIndex == 4)
        {
            hs4 = PlayerPrefs.GetInt("HS4", 0);
            highScore4.text = PlayerPrefs.GetInt("HighScore4", 0).ToString();
            deathCountTXT4.text = PlayerPrefs.GetInt("DeathCountTXT4", 0).ToString();
        }
        else if (sceneIndex == 5)
        {
            hs5 = PlayerPrefs.GetInt("HS5", 0);
            highScore5.text = PlayerPrefs.GetInt("HighScore5", 0).ToString();
            deathCountTXT5.text = PlayerPrefs.GetInt("DeathCountTXT5", 0).ToString();
        }
        else if (sceneIndex == 6)
        {
            hs6 = PlayerPrefs.GetInt("HS6", 0);
            highScore6.text = PlayerPrefs.GetInt("HighScore6", 0).ToString();
            deathCountTXT6.text = PlayerPrefs.GetInt("DeathCountTXT6", 0).ToString();
        }
        else
        {
            hs7 = PlayerPrefs.GetInt("HS7", 0);
            highScore7.text = PlayerPrefs.GetInt("HighScore7", 0).ToString();
            deathCountTXT7.text = PlayerPrefs.GetInt("DeathCountTXT7", 0).ToString();
        }
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = (player.position.x + 4.35).ToString("0");
        number = (int)(player.position.x + 4.35);
        /*
        if (sceneIndex == 0 && number > hs)
        {
            hs = number;
            PlayerPrefs.SetInt("HS", hs);
        }
        else if (sceneIndex == 1 && number > hs1)
        {
            hs1 = number;
            PlayerPrefs.SetInt("HS1", hs1);
        }
        else if (sceneIndex == 2 && number > hs2)
        {
            hs2 = number;
            PlayerPrefs.SetInt("HS2", hs2);
        }
        else if (sceneIndex == 3 && number > hs3)
        {
            hs3 = number;
            PlayerPrefs.SetInt("HS3", hs3);
        }
        else if (sceneIndex == 4 && number > hs4)
        {
            hs4 = number;
            PlayerPrefs.SetInt("HS4", hs4);
        }
        else if (sceneIndex == 5 && number > hs5)
        {
            hs5 = number;
            PlayerPrefs.SetInt("HS5", hs5);
        }
        else if (sceneIndex == 6 && number > hs6)
        {
            hs6 = number;
            PlayerPrefs.SetInt("HS6", hs6);
        }
        else if (sceneIndex == 7 && number > hs7)
        {
            hs7 = number;
            PlayerPrefs.SetInt("HS7", hs7);
        }
        */
        if(sceneIndex == 0 && number > DataControl.hs)
        {
            DataControl.hs = number;
        }
        else if (sceneIndex == 1 && number > DataControl.hs1)
        {
            DataControl.hs1 = number;
        }
        else if (sceneIndex == 2 && number > DataControl.hs2)
        {
            DataControl.hs2 = number;
        }
        else if (sceneIndex == 3 && number > DataControl.hs3)
        {
            DataControl.hs3 = number;
        }
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
        else if (sceneIndex == 4 && number > PlayerPrefs.GetInt("HighScore4", 0))
        {
            PlayerPrefs.SetInt("HighScore4", number);
            highScore4.text = number.ToString();
        }
        else if (sceneIndex == 5 && number > PlayerPrefs.GetInt("HighScore5", 0))
        {
            PlayerPrefs.SetInt("HighScore5", number);
            highScore5.text = number.ToString();
        }
        else if (sceneIndex == 6 && number > PlayerPrefs.GetInt("HighScore6", 0))
        {
            PlayerPrefs.SetInt("HighScore6", number);
            highScore6.text = number.ToString();
        }
        else if (sceneIndex == 7 && number > PlayerPrefs.GetInt("HighScore7", 0))
        {
            PlayerPrefs.SetInt("HighScore7", number);
            highScore7.text = number.ToString();
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
        else if (sceneIndex == 4)
        {
            PlayerPrefs.SetInt("DeathCountTXT4", PlayerControls.deathCount4);
            deathCountTXT4.text = PlayerControls.deathCount4.ToString();
        }
        else if (sceneIndex == 5)
        {
            PlayerPrefs.SetInt("DeathCountTXT5", PlayerControls.deathCount5);
            deathCountTXT5.text = PlayerControls.deathCount5.ToString();
        }
        else if (sceneIndex == 6)
        {
            PlayerPrefs.SetInt("DeathCountTXT6", PlayerControls.deathCount6);
            deathCountTXT6.text = PlayerControls.deathCount6.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("DeathCountTXT7", PlayerControls.deathCount7);
            deathCountTXT7.text = PlayerControls.deathCount7.ToString();
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
            else if (sceneIndex == 4)
                highScore4.text = "0";
            else if (sceneIndex == 5)
                highScore5.text = "0";
            else if (sceneIndex == 6)
                highScore6.text = "0";
            else highScore7.text = "0";
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
            else if (sceneIndex == 4)
                highScore4.text = "0";
            else if (sceneIndex == 5)
                highScore5.text = "0";
            else if (sceneIndex == 6)
                highScore6.text = "0";
            else highScore7.text = "0";
        }
    }

    public void GameIsPausedToFalse()
    {
        PauseMenu.GameIsPaused = false;
    }
}
