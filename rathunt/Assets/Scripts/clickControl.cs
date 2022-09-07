using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl : MonoBehaviour
{
    public bool control = true;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnMouseDown()
    {
        control = false;
        Destroy(gameObject);

    }

}
