using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public clickControl clickControl;
    public GameObject circle;
    public Text pointt;
    int point = 0;
    public timerScript timerScript;
    public GameObject canvas1;
    public GameObject gameover;
    public GameObject activebase;
    public Text points;
    public Text best;
    public AudioSource audioSrcc;

    void Awake()
    {

    }
    void Start()
    {
        point = 0;
        canvas1.SetActive(true);
        gameover.SetActive(false);
        audioSrcc = gameObject.GetComponent<AudioSource>();
        audioSrcc.clip = Resources.Load<AudioClip>("laugh");
    }


    void Update()
    {
        clickControl = GameObject.FindGameObjectWithTag("circle").GetComponent<clickControl>();



        if (!clickControl.control)
        {
            Debug.Log("girdi");
            timerScript.timeLeft = 1;
            spawn();
        }
        else if (timerScript.timeLeft < 0)
        {
            audioSrcc.Play();
            gameOver();
        }


    }

    public void spawn()
    {

                Vector2 spawnPos = new Vector2((Random.Range(-8f, 8f)), (Random.Range(-3.82f, 3.82f)));
                Instantiate(circle, spawnPos, Quaternion.identity);
                circle.SetActive(true);
                point++;
                pointt.text = "" + point;
                if(point > PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore", point);
        }
                clickControl.control = true;
    }

    public void gameOver()
    {
        points.text = point.ToString() + " RATS";
        best.text = "best is " + PlayerPrefs.GetInt("highscore");
        canvas1.SetActive(false);
        gameover.SetActive(true);
        StartCoroutine(waiter());
    }
    public IEnumerator waiter()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("menu");

    }
}
