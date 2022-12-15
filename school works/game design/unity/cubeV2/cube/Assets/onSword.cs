using UnityEngine;
using System.Collections;

public class onSword : MonoBehaviour {
    public GameObject player;
    public GameObject realPlayer;
	// Use this for initialization
	void Start () {
      //  transform.position = player.transform.position;
       
    }
    void Awake() 
{
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
       // transform.parent = realPlayer.transform;
    }
    // Update is called once per frame    
    void Update () {
        transform.position = player.transform.position;
       transform.rotation = player.transform.rotation;
      //  transform.parent = realPlayer.transform;

    }
}
