using System;
using UnityEngine;

public class PlayerStatsClass
{
    // Objects
    public string UserId;
    public int TimeTaken;
    public int LastTimeTaken;
    public long updateOn;

    // Empty Construstor
    public PlayerStatsClass() { }

    // Contrustor
    public PlayerStatsClass(string UserId, int TimeTaken, int LastTimeTaken)
    {
        this.UserId = UserId;
        this.TimeTaken = TimeTaken;
        this.LastTimeTaken = LastTimeTaken;

        var timestamp = this.GetTimeUnix();
        this.updateOn = timestamp;
    }

    public long GetTimeUnix()
    {
        return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }

    public string PlayerStatsToJson()
    {
        return JsonUtility.ToJson(this);
    }
}
