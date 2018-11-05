using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highScore;
    public Text highScore1;
    public Text highScore2;
    public Text highScore3;

    // Update is called once per frame
    void Update()
    {
        /*
        highScore.text = Score.hs.ToString();
        highScore1.text = Score.hs1.ToString();
        highScore2.text = Score.hs2.ToString();
        highScore3.text = Score.hs3.ToString();
        */
        highScore.text = DataControl.hs.ToString();
        highScore1.text = DataControl.hs1.ToString();
        highScore2.text = DataControl.hs2.ToString();
        highScore3.text = DataControl.hs3.ToString();
    }
}
