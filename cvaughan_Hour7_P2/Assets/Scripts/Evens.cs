using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x;
        x = 22;

        Debug.Log(x);

        while (x < 100)
        {
            x += 2;
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
