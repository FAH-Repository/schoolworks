using UnityEngine;
using System.Collections;

public class onPlayer : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start() {
        offset = transform.position;
    }



    // Update is called once per frame
    void LateUpdate() {
        transform.position = new Vector3(
      player.transform.position.x + offset.x, offset.y,
        offset.z);
    }
}