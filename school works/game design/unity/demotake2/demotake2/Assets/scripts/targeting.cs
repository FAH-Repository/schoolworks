using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class targeting : MonoBehaviour {
    public List<Transform> targets;
    public Transform selectedTarget;

    private Transform myTransform;
	// Use this for initialization
	void Start () {
       
        targets = new List<Transform>();
        selectedTarget = null;
        myTransform = transform;
        addAllEnemies();
    }

    public void addAllEnemies()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject enemy in go)
        {
            addTarget(enemy.transform);

        }

    }
    public void addTarget(Transform enemy)
    {
        targets.Add(enemy);
    }

    private void sortTargetByDis()
    {
        targets.Sort(delegate (Transform t1, Transform t2) {
            return Vector3.Distance(t1.position, myTransform.position).CompareTo(Vector3.Distance(t2.position, myTransform.position));
            });
            

    }

    private void targetEnemy()
    {
        if (selectedTarget == null)
        {
            sortTargetByDis();
            selectedTarget = targets[0];
        }
        else
        {
            int index = targets.IndexOf(selectedTarget);
            if (index < targets.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;

            }
            dTarget();
            selectedTarget = targets[index];
           
        }
        sTarget();
    }

    private void sTarget()
    {
        Transform health = selectedTarget.FindChild("health");
        health.GetComponent<Canvas>().enabled = true;
        

        playerattack1 pa = (playerattack1)GetComponent("playerattack1");
        pa.target = selectedTarget.gameObject;
    }
    private void dTarget()
    {
        Transform health = selectedTarget.FindChild("health");
        health.GetComponent<Canvas>().enabled = false;
    
        selectedTarget = null;

    }
    // Update is called once per frame
    void Update () {
      
       // if (curhealth == 0)
       
    if (Input.GetKeyDown(KeyCode.Tab))
       {
            targets.Clear();
            addAllEnemies();

         targetEnemy();
       }
        enemyhealth eh = (enemyhealth)selectedTarget.GetComponent("enemyhealth");
        if (eh.curhealth == 0)
        {

           


        }


    }
}
