using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal") / 30;
        float dirY = Input.GetAxis("Vertical") / 30;
        transform.Translate (dirX, dirY, 0);
    }
}
