using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public GameObject disableCanvas;

    public void CompleteLevel()
    {
        disableCanvas.SetActive(false);
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
