using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_menu : MonoBehaviour
{
    Sprite[] spritesheet;
    int colourID;
    int patternID;
    int designID;
    Image representation;

    //Use this for initialization
    void Start()
    {
        representation = GameObject.Find("Representation").GetComponent<Image>();
        colourID = 0;
        patternID = 0;
        designID = 5;
        spritesheet = Resources.LoadAll<Sprite>("Sprites/ball_sprites_v4");
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
            if (S.name.Equals("ball_sprites_v4_" + colourID + "_" + patternID))
            {
                representation.sprite = S;
                Global_variables.material = colourID +"_"+ patternID;
                Debug.Log(Global_variables.material);
            }
        }
    }

    public void ChangePattern()
    {
        if (patternID < 2)
        {
            patternID++;
            Debug.Log(patternID);
        }
        else if (patternID == 2)
        {
            patternID = 0;
            Debug.Log(patternID);
        }

        foreach (Sprite S in spritesheet)
        {
            if (S.name.Equals("ball_sprites_v4_" + colourID + "_" + patternID))
            {
                representation.sprite = S;
                Global_variables.material = colourID + "_" + patternID;
                Debug.Log(Global_variables.material);
            }
        }
    }

    public void ChangeDesign()
    {
        if (designID < 10)
        {
            designID++;
            Debug.Log(designID);
        }
        else if (designID == 10)
        {
            designID = 5;
            Debug.Log(designID);
        }

        foreach (Sprite S in spritesheet)
        {
            if (S.name.Equals("ball_sprites_v4_" + designID))
            {
                representation.sprite = S;
                Global_variables.material = "" + designID;
                Debug.Log(Global_variables.material);
            }
        }
    }
}
