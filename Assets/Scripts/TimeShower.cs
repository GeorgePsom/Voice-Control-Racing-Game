using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeShower : MonoBehaviour
{
    public bool touchScene;
    public TMP_Text lap1Timer;
    public TMP_Text lap2Timer;
    public TMP_Text lap3Timer;

    public TMP_Text timer;

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
        if(touchScene)
        {
            if (timeHolder.TouchLapTimes is not null)
            {
                lap1Timer.text = TimeSpan.FromSeconds(timeHolder.TouchLapTimes[0]).ToString("mm':'ss'.'fff");
                lap2Timer.text = TimeSpan.FromSeconds(timeHolder.TouchLapTimes[1]).ToString("mm':'ss'.'fff");
                lap3Timer.text = TimeSpan.FromSeconds(timeHolder.TouchLapTimes[2]).ToString("mm':'ss'.'fff");

                timer.text = TimeSpan.FromSeconds(timeHolder.TouchTime).ToString("mm':'ss'.'fff");
            }
        }
        else
        {
            if (timeHolder.VoiceLapTimes is not null)
            {
                lap1Timer.text = TimeSpan.FromSeconds(timeHolder.VoiceLapTimes[0]).ToString("mm':'ss'.'fff");
                lap2Timer.text = TimeSpan.FromSeconds(timeHolder.VoiceLapTimes[1]).ToString("mm':'ss'.'fff");
                lap3Timer.text = TimeSpan.FromSeconds(timeHolder.VoiceLapTimes[2]).ToString("mm':'ss'.'fff");

                timer.text = TimeSpan.FromSeconds(timeHolder.VoiceTime).ToString("mm':'ss'.'fff");
            }
        }
    }
}
