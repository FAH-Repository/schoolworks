using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

    public Vector3 direction = Vector3.zero;
        public float speed;
    Rigidbody rb;
    public GameObject player;


    void Update() 
{

       direction = player.transform.forward;
    }
	// Use this for initialization
	void Start () {
    
        //transform.rotation = player.transform.rotation;
        //  direction += player.transform.rotation;
        rb = GetComponent<Rigidbody>();
        if (direction.magnitude != 1.0f) 
            {
            direction.Normalize();

        }
        rb.velocity = direction * speed;
	}
	
	// Update is called once per frame
	void  OnCollisionEnter(Collision c) {
        //Destroy(GameObject);
        gameObject.SetActive(false);
	}
}
//clone.velocity = transform.TransformDirection(Vector3.forward* 10);        
//attach to bullet prefab