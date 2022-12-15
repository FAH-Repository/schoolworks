using UnityEngine;
using System.Collections;

public class meleeHit : MonoBehaviour {
    public GameObject target;

    GameObject Child;
    // Use this for initialization
    void Start () {

        Child = GameObject.FindGameObjectWithTag("Player").transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update () {
      
    }
    void OnCollisionEnter(Collision col)
    {
        target = col.gameObject;
        enemyhealth eh = (enemyhealth)target.GetComponent("enemyhealth");
        if (col.gameObject.tag == "enemy")
        {
            eh.AddjustCurHealth(-10);
        }

    }
}
