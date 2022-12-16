using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Firebase.Auth;

public class LoadandLogout : MonoBehaviour
{
    // Firebase Auth
    [Header("Firebase Auth")]
    private FirebaseAuth auth;

    private void Awake()
    {
        auth = FirebaseAuth.DefaultInstance;
        LogoutToLobby();
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }

    // Logout Logic 
    public void LogoutToLobby()
    {
        if (auth.CurrentUser != null)
        {
            Debug.LogFormat("Auth user {0} {1}", auth.CurrentUser.UserId, auth.CurrentUser.Email);
            auth.SignOut();
        }
    }
}
