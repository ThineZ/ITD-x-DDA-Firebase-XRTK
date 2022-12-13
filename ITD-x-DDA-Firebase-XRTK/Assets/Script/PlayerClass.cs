using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    // Objects
    public string email;
    public string password;
    public string username;

    // Empty Constructor
    public PlayerClass()
    {
    }

    // Account Storage Constructor
    public PlayerClass(string email, string password, string username)
    {
        this.email = email;
        this.password = password;
        this.username = username;
    }

    // Helper Function
    public string PlayerClassToJson()
    {
        return JsonUtility.ToJson(this);
    }
}