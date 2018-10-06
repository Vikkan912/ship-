using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0, 1000)]
    public float rot;
    public SpriteRenderer rend;
    public Color sColor;
    public float timer;
    public int speed = 20;
    public int x;
    [Range(0, 70)]
    public int right;
    public int newColor;
    public float ett;
    float två;
    float tre;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        

        
        if (Input.GetKey(KeyCode.D))
        {

            rend.color = new Color(0f, 0f, 1f);
            //det här gör så att så fort man trycker på D så ändras färgen till helblå

            transform.Rotate(0f, 0f, -rot * Time.deltaTime);
            //Rotate är så att den kan rotera. och jag har bara i rot. Z. så den kan röra sig upp eller ner.
            //inte åt dem andra hållen som X och Y
            //-rot gör så man går rot. åt höger.
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
            //Trans. gör så att den rör sig åt ett håll hela tiden.
            //space.Self gör så att den vet vad som är höger och vänster
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.color = new Color(0f, 1f, 0f);

            transform.Rotate(0f, 0f, right * Time.deltaTime);
            //rot(+) gör så att den åker åt andra hållet.
            //jag har right här för att den ska inte åka lika snabbt som rot
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rot /= 2;
            //den gör så att snabbheten på rot halveras 
            speed /= 2;
            //speed är hur snabbt den åker utan att hålla ner något. och den delas på hälften.

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rot *= 2;
            speed *= 2;
            //gör så att allt kommer tillbaka när man släpper S.
        }
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
        //den gör så att den alltid kommer att åka framåt. Time.deltatime gör så att den åker med sekund
        //istället för fps.
        timer += Time.deltaTime;
        if (timer > x)
        {
            x = x + 1;
            //varje gång X blir större än timern så plusas det föra talet med ett 
            print("timer: " + x);
            //att man ser timern i konsolen.
        }
        //C nivå.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.color = new Color(ett, två, tre);
            ett = Random.Range(0f, 1f);
            två = Random.Range(0f, 1f);
            tre = Random.Range(0f, 1f);
            //så.. jag vet inte om jag har gjort rät. men vad som händer är att varje gång du trycker space
            //så får ett, två och tre ett nytt värde. Det gör så att varje gång du trycker space får du en ny färg.
            //det jag inte förstår är om den ska alltid vara synlig. eller den ska bara finnas där om man inte trycker ner A eller D.
            //annars så gör man ett nytt script och lägger det på en annan del på skeppet(kolla part1 (1)).
        }
    }

}
