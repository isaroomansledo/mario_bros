using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_menu : MonoBehaviour
{
    Sprite[] spritesheet;
    int colourID;
    Image representation;

    //Use this for initialization
    void Start()
    {
        representation = GameObject.Find("Representation").GetComponent<Image>();
        colourID = 0;
     
        spritesheet = Resources.LoadAll<Sprite>("Sprites/RobotBoyIdleSprite");
    }

    public void ChangeColour()
    {
        if (colourID < 5)
        {
            colourID++;
            Debug.Log(colourID);
        }
        else if (colourID == 5)
        {
            colourID = 0;
            Debug.Log(colourID);
        }

        foreach (Sprite S in spritesheet)
        {
            if (S.name.Equals("RobotBoyIdle" + "0" + colourID))
            {
                representation.sprite = S;
                Global_variables.material = "0" + colourID;
                Debug.Log(Global_variables.material);
            }
        }
    }
}

    