using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using TMPro;

public class ColorSocket : MonoBehaviour
{
    [Header("Scoker Interactor")]
    public XRSocketInteractor myInteractor;
    public string correctTag;

    private static int CountCube;

    [Header("Door Anim")]
    [SerializeField] private Animator anim;


    [Header("Time")]
    public TMP_Text TimeUI;

    [Header("Firebase Obj")]
    public PlayerLevelDb LevelDB;
    public bool isPlayerStatesUpdated;
    FirebaseUser user;
    FirebaseAuth auth;


    private void Awake()
    {
        anim.SetBool("Open", false);

        myInteractor = GetComponent<XRSocketInteractor>();
        
        auth = FirebaseAuth.DefaultInstance;
    }

    public void socketLogic()
    { 
        //Debug.Log(myInteractor.selectTarget.name);
        //Debug.Log(myInteractor.selectTarget.CompareTag(correctTag));
        if (myInteractor.interactablesSelected.Count > 0 && myInteractor.interactablesSelected[0].transform.CompareTag(correctTag))
        {
            CountCube++;

            Debug.Log(CountCube);
            if (CountCube == 3)
            {

                // Check if is trigger then update
                if (!isPlayerStatesUpdated)
                {
                    anim.SetBool("Open", true);
                    UpdatePlayerStates(int.Parse(this.TimeUI.text), int.Parse(this.TimeUI.text));
                }
                isPlayerStatesUpdated = true;
            }
        }
    }

    // Linked Function From Level DB to Update Firebase
    private void UpdatePlayerStates(int Time, int LastTimeTaken)
    {
        LevelDB.UpdatePlayerStats(auth.CurrentUser.UserId, Time, LastTimeTaken);
    }
}