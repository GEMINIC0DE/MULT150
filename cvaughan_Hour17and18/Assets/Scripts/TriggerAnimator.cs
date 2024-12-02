using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimator : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Color Trigger");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Position Trigger");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Scale Trigger");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Spin Trigger");
        }
    }
}
