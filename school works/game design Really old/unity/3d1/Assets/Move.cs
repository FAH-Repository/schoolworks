using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
   public GameObject player;
    public float speed = 1.5f;
    public float jump = 2f;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        //right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-speed, 0, 0) * speed * Time.deltaTime;
        }
        //left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(speed, 0, 0) * speed * Time.deltaTime;
        }
        //up
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, -speed) * speed * Time.deltaTime;
        }
        //down
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, speed) * speed * Time.deltaTime;
        }
   
      
    }
}
