using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotLavaRock : MonoBehaviour
{
    public float health;

   

    private void Update()
    {
        if (health <= 0)
            Destroy(gameObject);
    }

}
