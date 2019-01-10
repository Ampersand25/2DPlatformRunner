using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highS;
    public Text highS1;
    public Text highS2;
    public Text highS3;

    // Use this for initialization
    void Start()
    {
        highS.text = DataControl.hs.ToString();
        highS1.text = DataControl.hs1.ToString();
        highS2.text = DataControl.hs2.ToString();
        highS3.text = DataControl.hs3.ToString();
    }
}
