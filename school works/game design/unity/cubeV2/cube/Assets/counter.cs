using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class counter : MonoBehaviour {
    public List<Transform> targets;
    // Use this for initialization
    void Start () {
        targets = new List<Transform>();
        addAllEnemies();
    }
	
	// Update is called once per frame
	void Update () {
	
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
}
