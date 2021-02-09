using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_menu : MonoBehaviour
{
    Sprite[] spritesheet;
    int colourID;
    int patternID;
    Image representation;

    //Use this for initialization
    void Start()
    {
        representation = GameObject.Find("Representation").GetComponent<Image>();
        colourID = 0;
        patternID = 0;
        spritesheet = Resources.LoadAll<Sprite>("Sprites/ball_sprites_v3");
    }

    public void ChangeColour()
    {
        if (colourID < 4)
        {
            colourID++;
            Debug.Log(colourID);
        }
        else if (colourID == 4)
        {
            colourID = 0;
            Debug.Log(colourID);
        }

        foreach (Sprite S in spritesheet)
        {
            if (S.name.Equals("ball_sprites_v3_" + colourID + "_" + patternID))
            {
                representation.sprite = S;
                Global_variables.material = colourID +"_"+ patternID;
                Debug.Log(Global_variables.material);
            }
        }
    }

    public void ChangePattern()
    {
        if (patternID < 1)
        {
            patternID++;
            Debug.Log(patternID);
        }
        else if (patternID == 1)
        {
            patternID = 0;
            Debug.Log(patternID);
        }

        foreach (Sprite S in spritesheet)
        {
            if (S.name.Equals("ball_sprites_v3_" + colourID + "_" + patternID))
            {
                representation.sprite = S;
                Global_variables.material = colourID + "_" + patternID;
                Debug.Log(Global_variables.material);
            }
        }
    }
}
