using UnityEngine;
using System.Collections;

public class enemyattack : MonoBehaviour
{
    public GameObject target;
    public float attacktimer;
    public float cooldown;
        public int dice1;
        public int dice2;


        private void RandomNumber() {
            dice1 = Random.Range(1, 3);
            Debug.Log(dice1);
            dice2 = Random.Range(1, 3);
            Debug.Log(dice2);
        }
    

        // Use this for initialization
        void Start()
    {
        attacktimer = 0;
        cooldown = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //
        if (attacktimer > 0) { 
            attacktimer -= Time.deltaTime;
    }
        if (attacktimer < 0) { 
        attacktimer = 0;
    }

        if (attacktimer == 0)
        {
            attack();
            attacktimer = cooldown;
        }

    }

    private void attack()
    {
       //calculates distance between it and player
        float distance = Vector3.Distance(target.transform.position, transform.position);
       
        Vector3 dir = (target.transform.position - transform.position).normalized;
        
        float direction = Vector3.Dot(dir, transform.forward);
        //limits range of attack
        Debug.Log(distance);
        if (distance < .26f)
        {
            //makes it so you have to face the enemy to attack
            if (direction > 0)
            {

                playerhealth ph = (playerhealth)target.GetComponent("playerhealth");
                ph.AddjustCurHealth(-8);
            }
        }
    }
}

