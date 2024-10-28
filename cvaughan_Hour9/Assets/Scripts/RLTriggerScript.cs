using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLTriggerScript : MonoBehaviour
{
    public GameObject objectYouWant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the " + objectYouWant.name);
    }
    void OnTriggerStay (Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the " + objectYouWant.name);
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the " + objectYouWant.name);
    }
}
