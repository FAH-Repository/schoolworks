using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public float speed = 1f;
    public GameObject player;
    public int sp = 0;
  
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.S)) {
            player.transform.position += new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.D)) {
            player.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A)) {
            player.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)) {
            player.transform.position += new Vector3(0, 0, speed);
        }

     

 }
        //  if (Input.GetKeyDown(KeyCode.Escape)) {

        //  speed = 0;


        //   }

    }

    
