using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Net;
using System;

public class PlayerDatabaseAuth : MonoBehaviour
{
    // Database Reference
    DatabaseReference db;
    DatabaseReference PlayerAccounts;

    // Firebase Auth
    [Header("Firebase Auth")]
    public FirebaseAuth auth;
    public FirebaseUser User;

    // Logic Objects
    [Header("Login")]
    public TMP_InputField LoginEmail;
    public TMP_InputField LoginPassword;
    public TMP_Text ErrorMSG;
    public Button Login;

    // Resister Objects
    [Header("Register")]
    public TMP_InputField ResEmail;
    public TMP_InputField ResPassword;
    public TMP_Text AlertDia;
    public Button Create;



    private void Awake()
    {
        // inti the database
        db = FirebaseDatabase.DefaultInstance.RootReference;

        // Account Database
        PlayerAccounts = FirebaseDatabase.DefaultInstance.GetReference("PlayerAccounts");

        // Create Method Called Here
        //Button CreateAcc = Create.GetComponent<Button>();

        // CreateAcc onClick AddListener Function
        //CreateAcc.onClick.AddListener(() => CreateAccounts(User.UserId, ResEmail.text.Trim(), ResPassword.text.Trim()));

        // Auth
        auth = FirebaseAuth.DefaultInstance;
    }


    // Create New Accounts into Firebase Database
    private void CreateAccounts(string uuid, string email, string password)
    {
        PlayerClass res = new PlayerClass(email, password);

        string checkChar = res.password;

        if (checkChar.Length < 6)
        {
            Debug.Log("Password too short");
        }
        else
        {
            PlayerAccounts.Child(uuid).SetRawJsonValueAsync(res.PlayerClassToJson());
        }
    }

    public void LoginFunction()
    {
        // Called the function 
        StartCoroutine(LoginLogic(LoginEmail.text.Trim(), LoginPassword.text.Trim()));
    }

    public void RegisterFunction()
    {
        // Called the function
        StartCoroutine(RegisterLogic(ResEmail.text.Trim(), ResPassword.text.Trim()));
    }

    // Login Logic
    private IEnumerator LoginLogic(string emailCheck, string pwdCheck)
    {
        Credential credential = EmailAuthProvider.GetCredential(emailCheck, pwdCheck);

        var loginTask = auth.SignInWithCredentialAsync(credential);

        yield return new WaitUntil(predicate: () => loginTask.IsCompleted);

        if (loginTask.Exception != null)
        {
            FirebaseException exception = (FirebaseException)loginTask.Exception.GetBaseException();

            AuthError error = (AuthError)exception.ErrorCode;

            string output = "Unknown Error, Please Re-try";

            switch (error)
            {
                case AuthError.MissingEmail:
                    output = "Please enter your email";
                    break;
                case AuthError.MissingPassword:
                    output = "Please enther your password";
                    break;
                case AuthError.InvalidEmail:
                    output = "Invalid Email";
                    break;
                case AuthError.WrongPassword:
                    output = "Incorrect Password";
                    break;
                case AuthError.UserNotFound:
                    output = "Account does not exist";
                    break;
            }
            ErrorMSG.text = output;
        }
        else
        {
            //DO SOMETHING
            User = loginTask.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})", User.DisplayName, User.Email);
            ErrorMSG.text = "";

            // Load to Play Scene
            SceneManager.LoadScene(0);
        }
    }

    private IEnumerator RegisterLogic(string ResEmail, string ResPWD)
    {
        if (ResEmail == "")
        {
            // If Email field is blank promt a warning
            AlertDia.text = "Missing Email";
        }
        else if (ResPWD == "")
        {
            AlertDia.text = "Missing Password";
        }
        else
        {
            // Call Firebase auth sign in function pass the email and pwd
            var ResFunc = auth.CreateUserWithEmailAndPasswordAsync(ResEmail, ResPWD);

            yield return new WaitUntil(predicate: () => ResFunc.IsCompleted);

            if (ResFunc.Exception != null)
            {
                // If have error handle them
                FirebaseException exception = ResFunc.Exception.GetBaseException() as FirebaseException;

                AuthError ResError = (AuthError)exception.ErrorCode;

                string output = "Register Failed !";

                switch (ResError)
                {
                    case AuthError.MissingEmail:
                        output = "Please enter your email";
                        break;
                    case AuthError.MissingPassword:
                        output = "Please enther your password";
                        break;
                    case AuthError.WeakPassword:
                        output = "Weak Password, min 6 charather";
                        break;
                    case AuthError.EmailAlreadyInUse:
                        output = "Email Already In Use";
                        break;
                }
                AlertDia.text = output;
            }
            else
            {
                // New User Created
                User = ResFunc.Result;

                // At the same time able to store User Stats into FireBase with UUID
                CreateAccounts(User.UserId, ResEmail.Trim(), ResPWD.Trim());

                if (User != null)
                {
                    // Create User Profile
                    UserProfile profile = new UserProfile { DisplayName = ResEmail };

                    // Call the Firebase auth update user profile
                    var ProfileTask = User.UpdateUserProfileAsync(profile);

                    // Wait Function
                    yield return new WaitUntil(predicate: () => ProfileTask.IsCompleted);

                    if (ProfileTask.Exception != null)
                    {
                        // If there are any errors handle them
                        Debug.LogWarning(message: $"Failed t register task with {ProfileTask.Exception}");

                        FirebaseException exception = ProfileTask.Exception.GetBaseException() as FirebaseException;

                        AuthError errorProfile = (AuthError)exception.ErrorCode;

                        AlertDia.text = "Account Set Failed";
                    }
                    else
                    {
                        AlertDia.text = "Account Created!!";
                    }
                }
            }
        }
    }
}