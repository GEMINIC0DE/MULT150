using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lightComponent = GetComponent<Light> ();
        lightComponent.type = LightType.Point;

            if (lightComponent.enabled == false && Input.GetKeyDown(KeyCode.L))
            {
                lightComponent.enabled = true;
            }
            else if (lightComponent.enabled == true && Input.GetKeyDown(KeyCode.L))
            {
                lightComponent.enabled = false;
            }
    }
}
