using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[Serializable]
public class User
{
    public string userName;
    public int userScore;
    public string nowtime;
    private int scene;
    public int level;
    
    

    public User()
    {
        userName = ScoreTextScript.playername;
        userScore = ScoreTextScript.coinAmount;
        nowtime = ScoreTextScript.time_now;
        scene = ScoreTextScript.level;
        if (scene == 2)
            level = 1;
        if (scene == 3)
            level = 2;
        if (scene == 4)
            level = 3;

    }
}