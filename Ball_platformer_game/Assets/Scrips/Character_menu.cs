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
        spritesheet = Resources.LoadAll<Sprite>("ball_sprites");
    }

    public void ChangeColour()
    {
        if (colourID < 2)
        {
            colourID++;
            Debug.Log(colourID);
        }
        else if (colourID == 2)
        {
            colourID = 0;
        }

        foreach (Sprite S in spritesheet)
        {
            if (S.name.Equals("ball_sprites_" + colourID))
            {
                representation.sprite = S;
            }
        }
    }
}
