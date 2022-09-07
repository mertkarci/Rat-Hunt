using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    public Sprite spray1, spray2;
    public AudioSource audioSrc;
    void Start()
    {
        Cursor.visible = false;
        audioSrc = gameObject.GetComponent<AudioSource>();
        audioSrc.clip = Resources.Load<AudioClip>("spraysound");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spray1;
            audioSrc.Play();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spray2;
        }
    }

}
