using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using TMPro;
using System;
using System.Globalization;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour
{
    public TMP_InputField PlayerName;
    public static string playername;
    public static string time_now;
    Text text;
    public static int coinAmount;
    public static int level;
    Scene scene;

    void Start()
    {
        text = GetComponent<Text>();
        time_now = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy   HH:mm");
    }

    
    void Update()
    {
        text.text = coinAmount.ToString();
    }

    private void PostToDatabase()
    {
        //Debug.Log("email1: "+Playeremail);
        User user = new User();
        //Debug.Log("email2: " + Playeremail);
        RestClient.Post("https://super-physio-bros-default-rtdb.firebaseio.com/" + playername + ".json", user);
    }

    public void OnSubmit()
    {
        playername = PlayerName.text;
        scene = SceneManager.GetActiveScene();
        level = scene.buildIndex;
        PostToDatabase();       
        SceneManager.LoadScene(0);
                
    }

    public static void date()
    {
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;
        String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            Console.WriteLine("{0}:", culture.NativeName);
            Console.WriteLine("   Local date and time: {0}, {1:G}",
                              localDate.ToString(culture), localDate.Kind);
            Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                              utcDate.ToString(culture), utcDate.Kind);
        }
    }

}
