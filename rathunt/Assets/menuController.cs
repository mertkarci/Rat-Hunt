using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    
    public Text best;

    void Start()
    {
        best.text = "BEST IS " + PlayerPrefs.GetInt("highscore");
    }

    public void menuSelector(int select)
    {
        if(select == 1)
        {
            SceneManager.LoadScene("level");
        }
        else if(select == 2)
        {
            Application.Quit();
        }
    }
}
