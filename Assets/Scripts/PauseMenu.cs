using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject PauseImg;
    public GameObject PlayImg;

    // Use this for initialization
    void Start() {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void RestartButton()
    {
        ++PlayerControls.ad;
        Time.timeScale = 0f;
        GameIsPaused = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Invoke("GameIsPausedToFalse", 0.0000000000000001f);
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PlayImg.SetActive(false);
        PauseImg.SetActive(true);
        Invoke("GameIsPausedToFalse", 0.0000000000000001f);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        PlayImg.SetActive(true);
        PauseImg.SetActive(false);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        PlayerControls.deathCount = PlayerControls.deathCount1 = PlayerControls.deathCount2 = PlayerControls.deathCount3 = 0;
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void PauseButton()
    {
        if(!GameIsPaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameIsPaused = false;
    }

    public void GameIsPausedToFalse()
    {
        GameIsPaused = false;
    }
}
