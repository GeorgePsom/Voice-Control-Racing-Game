using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTouchPractice()
    {
        SceneManager.LoadScene("s1 keyboard 1");
    }

    public void LoadTouch()
    {
        SceneManager.LoadScene("scene1-night keyboard");
    }

    public void LoadVoicePractice()
    {
        SceneManager.LoadScene("s1 voice");
    }

    public void LoadVoice()
    {
        SceneManager.LoadScene("scene1-night-voice");
    }

    public void LoadResults()
    {
        SceneManager.LoadScene("Results");
    }
}
