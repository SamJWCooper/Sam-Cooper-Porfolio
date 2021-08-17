using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailAreaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isOnFailZone;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Box")
        {
            isOnFailZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Box")
        {
            isOnFailZone = false;
        }
    }
}
