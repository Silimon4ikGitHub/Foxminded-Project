using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFire : MonoBehaviour
{
    

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rocket;
    [SerializeField] private Transform firePoint;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")) 
     {
        FireRocket();
     }   
    }
    private void FireRocket()
    {
        
        Rigidbody rocketClone = (Rigidbody) Instantiate(rocket, firePoint.position, transform.rotation);
    rocketClone.velocity = transform.right * speed;

    }
}
