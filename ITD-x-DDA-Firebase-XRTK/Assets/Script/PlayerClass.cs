using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    // Objects
    public string email;
    public string password;

    // Empty Constructor
    public PlayerClass()
    {
    }

    // Account Storage Constructor
    public PlayerClass(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    // Helper Function
    public string PlayerClassToJson()
    {
        return JsonUtility.ToJson(this);
    }
}