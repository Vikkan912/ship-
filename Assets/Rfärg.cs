using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rfärg : MonoBehaviour
{
    float ett;
    float två;
    float tre; public
    SpriteRenderer rend;
    public bool färgPAnnanDel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (färgPAnnanDel == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rend.color = new Color(ett, två, tre);
                ett = Random.Range(0f, 1f);
                två = Random.Range(0f, 1f);
                tre = Random.Range(0f, 1f);
            }
        }
    }
}
