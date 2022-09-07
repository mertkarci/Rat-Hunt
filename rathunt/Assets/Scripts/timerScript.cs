using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    Image timerBar;
    public float timeLeft;
    public float timeLimit;
    public spawner spawner;
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = timeLimit;
        spawner = GameObject.FindGameObjectWithTag("spawner").GetComponent<spawner>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / timeLimit;
        }
    }
}
