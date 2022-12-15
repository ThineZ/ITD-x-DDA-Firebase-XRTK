using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerLevelDb : MonoBehaviour
{
    [Header("Time UI")]
    public TMP_Text TimeUpdate;
    float startTime = 0f;

    // Database Ref
    DatabaseReference DBPlayerStates;

    private void Update()
    {
        TimeCount();
    }

    private void TimeCount()
    {
        startTime += 1 * Time.deltaTime;
        TimeUpdate.text = startTime.ToString("0");

        if (startTime <= 0)
        {
            startTime = 0;
        }
    }

    private void Awake()
    {
        InitFirebase();
    }

    private void InitFirebase()
    {
        DBPlayerStates = FirebaseDatabase.DefaultInstance.GetReference("PlayerStats");
    }

    public void UpdatePlayerStats(string uuid, int Time, int LastTimeTaken)
    {
        Query playerQuery = DBPlayerStates.Child(uuid);

        // READ the data first
        playerQuery.GetValueAsync().ContinueWithOnMainThread(updatetasker =>
        {
            if (updatetasker.IsFaulted || updatetasker.IsCanceled)
            {
                Debug.LogError("Sorry, there was an error creating your enteries, ERROR: " + updatetasker.Exception);
            }
            else if (updatetasker.IsCompleted)
            {
                // if there is an enter created check 
                DataSnapshot PlayerStatsSnapshot = updatetasker.Result;

                if (PlayerStatsSnapshot.Exists)
                {
                    // Update Player Stats
                    // Compare existing high score and set new high score
                    PlayerStatsClass ps = JsonUtility.FromJson<PlayerStatsClass>(PlayerStatsSnapshot.GetRawJsonValue());
                    Debug.Log(ps.PlayerStatsToJson());

                    Debug.Log(Time);
                    Debug.Log(ps.TimeTaken);

                    // Store Time of Player Clear Level
                    if (Time > ps.TimeTaken)
                    {
                        ps.TimeTaken = Time;
                    }

                    // Store Current Time Score
                    if (Time < ps.LastTimeTaken || Time > ps.LastTimeTaken)
                    {
                        ps.LastTimeTaken = Time;
                    }

                    // Update overide
                    DBPlayerStates.Child(uuid).Child("Level 1").SetRawJsonValueAsync(ps.PlayerStatsToJson());
                }
                else
                {
                    // Create Player Stats
                    // If there is no exist data, it is our first time player 
                    PlayerStatsClass ps = new PlayerStatsClass(uuid, Time, LastTimeTaken);

                    // Create new entries into firebase
                    DBPlayerStates.Child(uuid).Child("Level 1").SetRawJsonValueAsync(ps.PlayerStatsToJson());
                }
            }

        });
    }
}
