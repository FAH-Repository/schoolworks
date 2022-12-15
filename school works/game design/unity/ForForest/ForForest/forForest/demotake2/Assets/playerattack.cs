using UnityEngine;
using System.Collections;

public class playerattack : MonoBehaviour {
    public GameObject target;
    public float attacktimer;
    public float cooldown;
    public int damage;
   enum WEAPONTYPES { DEFAULT, IRON, STEEL, SILVER, DOREAN };


    // Use this for initialization
    void Start() {
        attacktimer = 0;
        cooldown = 2.0f;
    }

    // Update is called once per frame
    void Update() {
        if (attacktimer > 0) {
            attacktimer -= Time.deltaTime;
        }

        if (attacktimer < 0) {
            attacktimer = 0;
        }

        if (Input.GetKeyUp(KeyCode.F)) {
            if (attacktimer == 0) {
                attack();
                attacktimer = cooldown;
            }
        }

    }

    public void Startweapon()
    {
      
    }
    private void attack() {
        float distance = Vector3.Distance(target.transform.position, transform.position);

        Vector2 dir = (target.transform.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);
        //close to enemy to attack
        Debug.Log(distance);
        if (distance < 2.5f)
        {
            //must face enemy to attack
            if (direction > 0)
            {
                enemyhealth eh = (enemyhealth)target.GetComponent("enemyhealth");
                eh.AddjustCurHealth(-damage);
      
            }
        }
    }

}
