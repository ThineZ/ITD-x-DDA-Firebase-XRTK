using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    // Objects
    public string email;
    public string password;
    public string uuid;

    // Empty Constructor
    public PlayerClass()
    {
    }

    // Account Storage Constructor
    public PlayerClass(string email, string password, string uuid)
    {
        this.email = email;
        this.password = password;
        this.uuid = uuid;
    }

    // Helper Function
    public string PlayerClassToJson()
    {
        return JsonUtility.ToJson(this);
    }
}