using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int x = 0;

    void OnCollisionEnter(Collision collision)
    {
        x++;
        Debug.Log(x);
    }
}
