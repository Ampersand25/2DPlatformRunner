using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public void LoadMenu()
    {
        AdManager.lastDeathCount = PlayerControls.ad;
        StartCoroutine(LoadMainMenuAsynchronously());
    }

    public void LoadNextLevel()
    {
        AdManager.lastDeathCount = PlayerControls.ad;
        StartCoroutine(LoadNextLevelAsynchronously());
    }

    IEnumerator LoadMainMenuAsynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainMenu");
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = (int)(progress * 100f) + "%";
            yield return null;
        }
    }

    IEnumerator LoadNextLevelAsynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = (int)(progress * 100f) + "%";
            yield return null;
        }
    }
}
