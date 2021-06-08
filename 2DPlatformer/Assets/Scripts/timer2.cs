using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer2 : MonoBehaviour
{

public TMPro.TMP_Text Timer; //or you can use “public Text Timer” if you are not using textmashpro

private int second;

private int minute;

private float time;
public static string finish_time;





void Start()

{

second = 0;

minute = 0;

Timer.text = "00:00";

}



void Update()

{

time += Time.deltaTime;

        if (time >= 1)

        {

            second ++;

            time = time - 1;

        }



        if (second == 60)

        {

            minute++;

            second = 0;

        }

        Timer.text = "Time: " + minute.ToString() + ":" + second.ToString();
        finish_time= "Time: " + minute.ToString() + ":" + second.ToString();

}

}
