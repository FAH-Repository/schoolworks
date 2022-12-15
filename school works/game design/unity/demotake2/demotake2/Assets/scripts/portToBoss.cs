using UnityEngine;
using System.Collections;

public class portToBoss : MonoBehaviour {
    float portUseDis = .3f;
    public Transform portal;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(portal.transform.position, this.transform.position);
        if (distance <= portUseDis && Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Done_Main");
        }
    }
}
