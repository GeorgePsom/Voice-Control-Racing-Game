using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeShower2 : MonoBehaviour
{
    public TMP_Text vlap1Timer;
    public TMP_Text vlap2Timer;
    public TMP_Text vlap3Timer;


    public TMP_Text vtimer;

    public TMP_Text tlap1Timer;
    public TMP_Text tlap2Timer;
    public TMP_Text tlap3Timer;


    public TMP_Text ttimer;

    private TimeHolder timeHolder;

    // Start is called before the first frame update
    void Start()
    {
        var timeHolderObject = GameObject.Find("Time Holder");
        if (timeHolderObject is null)
        {
            timeHolderObject = new GameObject();
            timeHolderObject.name = "Time Holder";
            timeHolderObject.AddComponent<TimeHolder>();
        }
        timeHolder = timeHolderObject.GetComponent<TimeHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeHolder.TouchLapTimes?.Length >= 3)
        {
            tlap1Timer.text = TimeSpan.FromSeconds(timeHolder.TouchLapTimes[0]).ToString("mm':'ss'.'fff");
            tlap2Timer.text = TimeSpan.FromSeconds(timeHolder.TouchLapTimes[1]).ToString("mm':'ss'.'fff");
            tlap3Timer.text = TimeSpan.FromSeconds(timeHolder.TouchLapTimes[2]).ToString("mm':'ss'.'fff");

            ttimer.text = TimeSpan.FromSeconds(timeHolder.TouchTime).ToString("mm':'ss'.'fff");
        }

        if (timeHolder.VoiceLapTimes?.Length >= 3)
        {
            vlap1Timer.text = TimeSpan.FromSeconds(timeHolder.VoiceLapTimes[0]).ToString("mm':'ss'.'fff");
            vlap2Timer.text = TimeSpan.FromSeconds(timeHolder.VoiceLapTimes[1]).ToString("mm':'ss'.'fff");
            vlap3Timer.text = TimeSpan.FromSeconds(timeHolder.VoiceLapTimes[2]).ToString("mm':'ss'.'fff");

            vtimer.text = TimeSpan.FromSeconds(timeHolder.VoiceTime).ToString("mm':'ss'.'fff");
        }
    }
}
