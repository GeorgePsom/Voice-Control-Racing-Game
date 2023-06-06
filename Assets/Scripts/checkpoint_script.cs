using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint_script : MonoBehaviour
{
    public static int CheckPointCount = 5; // total checkpoints + finish line
    public int CheckPointNr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(name);
        var car = GameObject.Find("Prometheus").GetComponent<PrometeoCarController>();
        var timeHolderObject = GameObject.Find("Time Holder");
        if (timeHolderObject is null)
        {
            timeHolderObject = new GameObject();
            timeHolderObject.name = "Time Holder";
            timeHolderObject.AddComponent<TimeHolder>();
        }
        var timeHolder = timeHolderObject.GetComponent<TimeHolder>();
        var practiceMode = other.transform.parent.gameObject.transform.parent.gameObject.GetComponent<PracticeModeScript>();
        
        if (car != null)
        {
            if (car.lastCheckpoint.CheckPointNr == CheckPointNr)
            {
                car.lastCheckpoint = this;
                return;
            }

            if (car.lastCheckpoint.CheckPointNr == CheckPointNr - 1)
            {
                car.lastCheckpoint = this;
                return;
            }

            if(car.lastCheckpoint.CheckPointNr == CheckPointNr + 1)
            {
                car.lastCheckpoint = this;
                return;
            }

            if(car.lastCheckpoint.CheckPointNr == 4 && CheckPointNr == 0)
            {
                Debug.Log("lap");
                var currentTime = TimeSpan.FromSeconds(car.currentTime);
                var currentLapTime = TimeSpan.FromSeconds(car.currentLapTime);
                Debug.Log(currentTime.ToString("mm':'ss")); // 00:03:48
                Debug.Log(currentLapTime.ToString("mm':'ss"));
                Debug.Log(car.currentLapTime);
                car.lapTimes[car.lapCounter++] = car.currentLapTime;
                car.currentLapTime = 0;
                car.lastCheckpoint = this;
                if (practiceMode is not null)
                {
                    practiceMode.endPractice = true;
                }
                if (car.lapCounter >= 3)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        if (car.useVoiceControls)
                        {
                            timeHolder.VoiceLapTimes = car.lapTimes;
                            timeHolder.VoiceTime = car.currentTime;
                            SceneManager.LoadScene("Voice Race End");
                        }
                        else
                        {
                            timeHolder.TouchLapTimes = car.lapTimes;
                            timeHolder.TouchTime = car.currentTime;
                            SceneManager.LoadScene("Touch Race End");
                        }
                    }
                }
            }
        }
        
    }
}
