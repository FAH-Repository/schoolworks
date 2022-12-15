using UnityEngine;
using System.Collections;

public class animS : MonoBehaviour {
    public Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("attack", true);

        }
        else
        {
            anim.SetBool("attack", false);

        }
    }
}
