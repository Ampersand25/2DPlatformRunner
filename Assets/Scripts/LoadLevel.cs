using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public Animator transitionAnim;

    public void RandomLevel()
    {
        // PlayerControls.deathCount = 0;
        StartCoroutine(RandomAsynchronously());
    }

    public void LoadScene(string levelName)
    {
        // PlayerControls.deathCount = 0;
        StartCoroutine(LoadAsynchronously(levelName));
    }

    IEnumerator LoadAsynchronously(string levelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = (int)(progress * 100f) + "%";
            yield return null;
        }
        // transitionAnim.SetTrigger("End");
        // yield return new WaitForSeconds(1.5f);
    }

    IEnumerator RandomAsynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Random.Range(1, 7));
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = (int)(progress * 100f) + "%";
            yield return null;
        }
        // transitionAnim.SetTrigger("End");
        // yield return new WaitForSeconds(1.5f);
    }
}
