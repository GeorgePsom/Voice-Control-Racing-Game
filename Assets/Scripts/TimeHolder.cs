using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHolder : MonoBehaviour
{
    public static TimeHolder instance;

    public float[] TouchLapTimes = null;
    public float[] VoiceLapTimes = null;

    public float TouchTime = float.NaN;
    public float VoiceTime = float.NaN;


    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
