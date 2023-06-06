using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Respawner : MonoBehaviour
{

    public GameObject respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R) && respawnPoint is not null)
        {
            transform.position = respawnPoint.transform.position;
            transform.rotation = respawnPoint.transform.rotation;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
