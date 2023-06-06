using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticeModeScript : MonoBehaviour
{
    float practiceTime = 300f;
    float currentTime = 0;

    public bool endPractice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > practiceTime || endPractice)
        {
            if (SceneManager.GetActiveScene().name == "s1 keyboard 1")
            {
                SceneManager.LoadScene("End Touch Practice");
            }
            else
            {
                SceneManager.LoadScene("End Voice Practice");
            }
        }
    }
}
