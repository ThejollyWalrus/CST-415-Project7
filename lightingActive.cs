using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightingActive : MonoBehaviour
{
    // Start is called before the first frame update
  


        public GameObject NameOfGameObjectThatYouWantToActivate;
        public Light lighter;
        void Start()
        {
            NameOfGameObjectThatYouWantToActivate.SetActive(true);
            NameOfGameObjectThatYouWantToActivate.SetActive(false);
        }


    // Update is called once per frame
    void Update()
    {
        if (lighter.intensity <= 0)
            NameOfGameObjectThatYouWantToActivate.SetActive(true);
    }
}
