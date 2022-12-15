using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{
    public GameObject target;
   
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    void Start()
    {

        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        playerhealth ph = (playerhealth)target.GetComponent("playerhealth");
        if (ph.curhealth <= 0f)
        {
            return;
        }
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
