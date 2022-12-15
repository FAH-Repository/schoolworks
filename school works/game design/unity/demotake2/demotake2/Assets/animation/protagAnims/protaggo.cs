using UnityEngine;
using System.Collections;

public class protaggo : MonoBehaviour {
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
      //  public bool fup = Anim.bool("up");
//idle
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("up", false);
            anim.SetBool("down",true);
            anim.SetBool("left",false);
            anim.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }

            if (Input.GetKey(KeyCode.A))
            {
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("left",false);
            anim.SetBool("right", true);
        }

            if (Input.GetKey(KeyCode.D))
            {
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }


//walking
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("walkdown", true);
        }
        else {
            anim.SetBool("walkdown", false);
        }



        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("walkup", true);
        }
        else {
            anim.SetBool("walkup", false);
        }



        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("walkright", true);

        }
        else {
            anim.SetBool("walkright", false);
        }



        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("walkleft", true);
        }
        else {
            anim.SetBool("walkleft", false);
        }
        // attack
//down attack
        if (Input.GetKey(KeyCode.K) && (anim.GetBool("down") == true || anim.GetBool("walkdown") == true))
        {     
            anim.SetBool("downA", true); 
        }
      else 
        {
            anim.SetBool("downA", false);
        }
//attack up
        if (Input.GetKey(KeyCode.K) && (anim.GetBool("up") == true || anim.GetBool("walkup") == true))
        {
            anim.SetBool("upA", true);
        }
        else
        {
            anim.SetBool("upA", false);
        }
        //attack left
        if (Input.GetKey(KeyCode.K) && (anim.GetBool("right") == true || anim.GetBool("walkright") == true))
        {
            anim.SetBool("leftA", true);
        }
        else
        {
            anim.SetBool("leftA", false);
        }
        //attack right
        if (Input.GetKey(KeyCode.K) && (anim.GetBool("left") == true || anim.GetBool("walkleft") == true))
        {
            anim.SetBool("rightA", true);
        }
        else
        {
            anim.SetBool("rightA", false);
        }
    }
    }

