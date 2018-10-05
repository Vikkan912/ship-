using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(-1000, 1000)]
    public float rot;
    public SpriteRenderer rend;
    public Color sColor;
    public int timer;
    public int speed = 20;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rend.color = sColor;
            rend.color = new Color(0f, 0f, 1f);
            
            transform.Rotate(0f, 0f,-rot * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.color = sColor;
            rend.color = new Color(0f,1f,0f);
            transform.Rotate(0f,0f, rot * Time.deltaTime);
         transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
       if (Input.GetKeyDown(KeyCode.S))
        {
            rot -= 150;
            speed -= 10;

        }
       if (Input.GetKeyUp(KeyCode.S))
        {
            rot += 150;
            speed += 10;
        }
        transform.Translate(speed* Time.deltaTime, 0, 0, Space.Self);
        timer += 1;
        print("test");
    }

}
