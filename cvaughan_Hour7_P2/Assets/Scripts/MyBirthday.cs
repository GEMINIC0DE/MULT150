using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x;
        x = 1;

        while (x < 31)
        {

            if (x != 13)
            {
                Debug.Log(x);
            }
            else
            {
                Debug.Log("Its my birthday!");
            }
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
