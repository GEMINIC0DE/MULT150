using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("Bullet Variables")]
    public float bulletSpeed;
    public float bulletDamage;
    

    [Header("Initial Setup")]
    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;

    //AudioSource audioSource;

    //void Start()
    //{
        //audioSource = GetComponent<AudioSource>();
    //}


    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //audioSource.Start();
            Shoot();
        }
        
    }


    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("WorldObjectHolder").transform);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnTransform.forward * bulletSpeed, ForceMode.Impulse);
        bullet.GetComponent<BulletController>().damage = bulletDamage;
    }
}
