using UnityEngine;
using System.Collections;

public class goblinAnimBehaviour : MonoBehaviour
{
    public Animator anim;
    float LastPositionX;
    float LastPositionZ;
    public Transform playa;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {
     float x =   playa.position.x;
        float z = playa.position.z;
        LastPositionX = transform.position.x;
        LastPositionZ = transform.position.z;
        //  public bool fup = Anim.bool("up");
        if (LastPositionZ > z)
        {
            anim.SetBool("up", false);
            anim.SetBool("down", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }

        if (LastPositionZ < z)
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }

        if (LastPositionX > x)
        {
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }

        if (LastPositionX < x)
        {
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("left", false);
            anim.SetBool("right", true);
        }



        if (LastPositionZ > z)
        {
            anim.SetBool("walkdown", true);
        }
        else
        {
            anim.SetBool("walkdown", false);
        }



        if (LastPositionZ < z)
        {
            anim.SetBool("walkup", true);
        }
        else
        {
            anim.SetBool("walkup", false);
        }



        if (LastPositionX < x)
        {
            anim.SetBool("walkright", true);

        }
        else
        {
            anim.SetBool("walkright", false);
        }



        if (LastPositionX > x)
        {
            anim.SetBool("walkleft", true);
        }
        else
        {
            anim.SetBool("walkleft", false);
        }

    
    }
}
