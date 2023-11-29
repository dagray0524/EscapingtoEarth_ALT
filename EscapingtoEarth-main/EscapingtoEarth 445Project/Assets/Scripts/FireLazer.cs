using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLazer : MonoBehaviour
{
    public float timeBetweenBullets = 0.15f;
    public GameObject Projectile;

    float nextBullet;
    
    void Awake()
    {
    nextBullet = 0f;    
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController myPlayer = transform.root.GetComponent<PlayerController>();

        if (Input.GetKeyDown("space") && nextBullet<Time.time){
            nextBullet = Time.time +timeBetweenBullets;
            Instantiate(Projectile,transform.position,transform.rotation);
            
        }
    }
}
