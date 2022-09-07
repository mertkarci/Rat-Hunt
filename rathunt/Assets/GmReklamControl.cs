using System;
using UnityEngine;
using UnityEngine.UI;

public class GmReklamControl : MonoBehaviour
{

    public static bool GD_isActive = true;

    void Awake()
    {
        GameMonetize.OnResumeGame += OnResumeGame;
        GameMonetize.OnPauseGame += OnPauseGame;
        //GameDistribution.OnResumeGame += OnResumeGame;
        //GameDistribution.OnPauseGame += OnPauseGame;
        // GameDistribution.OnPreloadRewardedVideo += OnPreloadAd;
    }

    public void OnResumeGame()
    {
        isVideo = false;
        Debug.LogWarning("reklam cikdi  ");
        AudioListener.pause = false;
        Time.timeScale = 1;

        // RESUME MY GAME
        //  infoText.text = "RESUME GAME";
    }
    bool isVideo = false;
    public void OnPauseGame()
    {
        isVideo = true;
        Time.timeScale = 0;
        AudioListener.pause = true;
        // PAUSE MY GAME
        //  infoText.text = "GAME PAUSED";      
    }

    public void OnPreloadAd(int loaded)
    {
        // FEEDBACK ABOUT PRELOADED AD

    }

    private void Update()
    {
        if (isVideo)
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
        }
    }

    public void showAdd()
    {
        ShowAd();
    }
    public static void showAd()
    {
        ShowAd();
    }

    static void ShowAd()
    {
        if (GD_isActive)
            GameMonetize.Instance.ShowAd();
           // GameDistribution.Instance.ShowAd();
    }

    public void ShowRewardedAd()
    {
        
        //GameDistribution.Instance.ShowRewardedAd();
    }


    public void PreloadRewardedAd()
    {
        
        //GameDistribution.Instance.PreloadRewardedAd();
    }
}
