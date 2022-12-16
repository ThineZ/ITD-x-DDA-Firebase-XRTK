using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using UnityEngine.UI;

public class Logout : MonoBehaviour
{
    // Firebase Auth
    [Header("Firebase Auth")]
    public FirebaseAuth auth;

    private void Awake()
    {
        // Auth
        auth = FirebaseAuth.DefaultInstance;
    }

    // Logout Logic
    public void LogoutLogic()
    {
        if (auth.CurrentUser != null)
        {
            Debug.LogFormat("Auth user {0} {1}", auth.CurrentUser.UserId, auth.CurrentUser.Email);
            auth.SignOut();

            SceneManager.LoadScene(0);
        }
    }
}
