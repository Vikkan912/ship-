using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0, 10000)]
    public float rot;
    public SpriteRenderer rend;
    public Color sColor;
    public float timer;
    public float speed;
    public int x;
    [Range(0, 7000)]
    public float right;
    public int newColor;
    float ett;
    float två;
    float tre;
    float skX;
    float skY;

    // Use this for initialization
    void Start()
    {
        speed = Random.Range(800, 1000);
        //när man börjar spelet så sätter den in en random speed. ( inte rot.) Vet inte om man ska göra det.

        speed *= Time.deltaTime;
        rot *= Time.deltaTime;
        right *= Time.deltaTime;
        //jag gångrar in  Time.delta så att den är inte beroende av framerate längre. och åker lika långt oavsett frames.

        transform.Translate(Random.Range(-18, 14), Random.Range(-18, 21), 0);
        //trans.Translate gör så att den spawnar på ett ställe. Random.Range är där för att man ska spawna på ett random ställe
        // nollan är där för att den inte ska gå på y axeln. För då kan den hamna bakom skärmen.   

        //Y = 23,1. -24,9  X=43,7. -38.7
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
            //färgen blir grön. Och gör att den blirdet.
            transform.Rotate(0f, 0f, right * Time.deltaTime);
            //Right(+) gör så att den åker åt andra hållet.
            //jag har right här för att den ska inte åka lika snabbt som rot
            // eller så kan man göra att man skriver in rot. 0f, 0f, rot /2. så den går hälften av roten.
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rot /= 2;
            //den gör så att snabbheten på rot halveras 
            speed /= 2;
            //speed är hur snabbt den åker utan att hålla ner något. och den delas på hälften.
            right /= 2;

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rot *= 2;
            speed *= 2;
            right *= 2;
            //gör så att allt kommer tillbaka när man släpper S.
        }
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
        //den gör så att den alltid kommer att åka framåt. Time.deltatime gör så att den åker med sekund
        //istället för fps.
        timer += Time.deltaTime;
        if (timer > x)
        {
            x = x + 1;
            print("timer: " + x);
            //varje gång X blir större än timern så plusas det föra talet med ett 
            //att man ser timern i konsolen.(printar ut det.)
            //den printar ut två gånger för att jag har två scripts.
        }
        //C nivå.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.color = new Color(ett, två, tre);
            ett = Random.Range(0f, 1f);
            två = Random.Range(0f, 1f);
            tre = Random.Range(0f, 1f);
        }
        //så.. jag vet inte om jag har gjort rätt. men vad som händer är att varje gång du trycker space
        //så får ett, två och tre ett nytt värde. Det gör så att varje gång du trycker space får du en ny färg.
        //det jag inte förstår är om den ska alltid vara synlig. eller den ska bara finnas där om man inte trycker ner A eller D.
        //annars så gör man ett nytt script och lägger det på en annan del på skeppet(kolla part1 (1)).

        if (transform.position.x > 38.30f)
        {
            transform.position = new Vector3(-38f,
                transform.position.y,
                transform.position.z);
            //när skeppet kommer till kod. 38.30 bå x axeln så åker den till samma ställe på den nedre axeln. det vill säga att den åker till -istället
        }
        if (transform.position.x < -38f)
        {
            transform.position = new Vector3(
                38.30f,
                transform.position.y,
                transform.position.z);
            // samma sack som förut. men nu åker den istället upp till 38,30 om den kommer utanför -38.
        }
        if (transform.position.y < -22f)
        {
            transform.position = new Vector3(
                transform.position.x,
                22f,
                transform.position.z);
            // nu blir det på y axeln istället för x axeln.
        }
        if (transform.position.y > 22f)
        {
            transform.position = new Vector3(
                transform.position.x,
                -22f,
                transform.position.z);

        }
        
    }
}


