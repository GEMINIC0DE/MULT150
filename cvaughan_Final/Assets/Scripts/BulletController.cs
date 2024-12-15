using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float damage;
    public float lifeTime = 3;


    private void Update()
    {
        lifeTime -= Time.deltaTime;

        if(lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HotLavaRock>() != null)
            other.GetComponent<HotLavaRock>().health -= damage;
        
        Destroy(gameObject);
    }
}
