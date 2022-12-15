using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public GameObject scrollyTexttheObject;
    public float speed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        scrollyTexttheObject.transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
}
