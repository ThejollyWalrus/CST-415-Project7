using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightDim : MonoBehaviour
{
   // public Light lightLow;
    float darker = 0.25f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //lightLow.intensity -= 1;
    }
    void OnTriggerEnter(Collider blocker)
    {
        if (blocker.CompareTag("box"))
        {
          //  lightLow.intensity -= darker;
        }
    }
}
