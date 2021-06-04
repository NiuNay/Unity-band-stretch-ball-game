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

    public User()
    {
        userName = PlayerController.playername;
        userScore = PlayerController.count;
        Debug.Log("userclass: "+userName);
        Debug.Log("userclass: "+userScore);
    }
}