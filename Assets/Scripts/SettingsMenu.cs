using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public GameObject Music;
    public GameObject Sound;
    public GameObject NoSound;
    public GameObject Ads;
    public GameObject NoAds;
    public static bool adsActivated = true;
    
    // Use this for initialization
    void Start() {
        if (adsActivated == false)
        {
            Ads.SetActive(false);
            NoAds.SetActive(true);
        }
        else
        {
            NoAds.SetActive(false);
            Ads.SetActive(true);
        }
        if (AudioListener.pause == false)
        {
            NoSound.SetActive(false);
            Sound.SetActive(true);
        }
        else
        {
            NoSound.SetActive(true);
            Sound.SetActive(false);
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void disableSound()
    {
        if (!PauseMenu.GameIsPaused)
        {
            Time.timeScale = 0f;
            PauseMenu.GameIsPaused = true;
            if (AudioListener.pause == false)
            {
                //AudioListener.pause = true;
                NoSound.SetActive(true);
                Sound.SetActive(false);
            }
            else
            {
                //AudioListener.pause = false;
                NoSound.SetActive(false);
                Sound.SetActive(true);
            }
            AudioListener.pause = !AudioListener.pause;
            Time.timeScale = 1f;
            Invoke("GameIsPausedToFalse", 0.0000000000000001f);
        }
        else
        {
            if (AudioListener.pause == false)
            {
                //AudioListener.pause = true;
                NoSound.SetActive(true);
                Sound.SetActive(false);
            }
            else
            {
                //AudioListener.pause = false;
                NoSound.SetActive(false);
                Sound.SetActive(true);
            }
            AudioListener.pause = !AudioListener.pause;
        }
    }

    public void disableAds()
    {
        if (adsActivated == false)
        {
            NoAds.SetActive(false);
            Ads.SetActive(true);
        }
        else
        {
            Ads.SetActive(false);
            NoAds.SetActive(true);
        }
        adsActivated = !adsActivated;
    }

    public void GameIsPausedToFalse()
    {
        PauseMenu.GameIsPaused = false;
    }
}
