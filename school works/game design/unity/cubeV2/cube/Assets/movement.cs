using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
   public GameObject player;
    public float speed = 4.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        //player.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;       
        // player.transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;       
    }
}//sup dawg
