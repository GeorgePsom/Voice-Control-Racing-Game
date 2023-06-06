using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSetScript : MonoBehaviour
{
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
        var respawner = other.gameObject.transform.parent.transform.parent.GetComponent<Respawner>();
        if (respawner is not null)
        {
            respawner.respawnPoint = gameObject;
        }
        
    }
}
