using UnityEngine;
using System.Collections;


public class FireballRocket : MonoBehaviour
{
    public Rigidbody fireBall;
    public float speed = 10f;
    void FireRocket()
    {
        Rigidbody rocketClone = (Rigidbody)Instantiate(fireBall, transform.position, transform.rotation);
        rocketClone.velocity = transform.forward * speed;
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireRocket();
        }
    }
}

