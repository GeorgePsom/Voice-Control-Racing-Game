using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapUpdater : MonoBehaviour
{

    public TMP_Text lapTimer;
    public TMP_Text timer;
    public TMP_Text lapCounter;

    public PrometeoCarController car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "Total time: " + TimeSpan.FromSeconds(car.currentTime).ToString("mm':'ss'.'fff");
        lapTimer.text = "Lap time: " + TimeSpan.FromSeconds(car.currentLapTime).ToString("mm':'ss'.'fff");
        lapCounter.text = "Lap: " + (car.lapCounter + 1) + "/3";
    }
}
