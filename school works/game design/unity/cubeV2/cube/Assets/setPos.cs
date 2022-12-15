using UnityEngine;
using System.Collections;

public class setPos : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        Vector3 temp = transform.position; // world pos
       // transform.parent = null; // *should* not move, but you say...
        transform.position = temp;
       
    }
	
	// Update is called once per frame
	void Update () {
     
    }
}
