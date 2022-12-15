using UnityEngine;
using System.Collections;

public class inAttackRight : MonoBehaviour {
    public Animator anim;
    public int damage;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
    void onTriggerStay(Collider other)
    {
        if (anim.GetBool("left")== true && Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("collided!");
            damage = 20;
            enemyhealth eh = (enemyhealth)other.GetComponent("enemyhealth");
            eh.AddjustCurHealth(-damage);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
