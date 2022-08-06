using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Gamemanager : MonoBehaviour
{
    //Score of My game Button
    int score = 0;
    string NiceOne = "Rich man chill Please !!!";
    string PoorOne = "You are so poor HaHa loser (:";
    string StopMony = "you are crazy man i dont have money for you i am a Loser not You ):";
    string FreePIzza = "look i will give you a free Pizza Put Stop Please!!";
    string Error404 = "ERROR 404 ERROR 404 ERROR 404 ERROR 404 ERROR 404 ERROR 404 ERROR 404 ";
    int increment = 1;
    public Text text1;
    public Text poor;
    public Text Rich;
    public Text Stop;
    public Text FreePizza;
    public Text Error;

    // Start is called before the first frame update
    void Start()
    {
        //start is sad Now i Dont know Why!! ):
        print("Welcome to clicker Game Enjoy <3 ");
    }

    // Update is called once per frame
    void Update()
    {



    }

     //increase 

    public void increase()
    {
        score += increment;
        text1.text = score.ToString();

           if (score > 100)
        {
            print("Yo Rich man chill ");
            Rich.text = NiceOne.ToString();


        }
        if (score > 1000)
        {
            print("you are crazy i dont have any mony for you Please Stop");
            Stop.text = StopMony.ToString();
            


        }
        if (score > 500)
        {
            print("Ok i will give you free Pizza But stop please!!");
            FreePizza.text = FreePIzza.ToString();



        }
        if (score > 10000)
        {
            print("ERROR 404 STOP");
            Error.text = Error404.ToString();



        }


        // my store pizza
    }
    public void store()

    {

        if (score > 5)
        {


            increment++;
            score -= 5;
            text1.text = score.ToString();
            poor.text = PoorOne.ToString();





        }

        else if(score < 5 )
        {

            print("you are poor  ):");
            poor.text = PoorOne.ToString();
        }
        else
        {
            print("you are luck one ");
        }


    }







}



