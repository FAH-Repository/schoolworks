using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {
    public Transform target;
    public int moveSpeed;
    public int roationSpeed;
    public int safeDistance = 3;
    public GameObject player;
    public GameObject self;
    public int sightRange = 20;
public AudioSource MonsterRoar;

    private Transform myTransform;

    void Awake() {
        myTransform = transform;

    }

	// Use this for initialization
	void Start () {
        GameObject go = GameObject.FindGameObjectWithTag("player");

        target = go.transform;

	}
	
	// Update is called once per frame
	void Update () {// od is object distance
        var od = Vector3.Distance(player.transform.position, self.transform.position);

        //finds path
        Debug.DrawLine(target.position, myTransform.position, Color.yellow);


        if (od > safeDistance && od < sightRange) {
            //making so it follows you much longer after it has seen you
            sightRange = 50;
            //move toward target
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            //looks at player
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), roationSpeed * Time.deltaTime);
                                                }
//this happens if the enemy is close to the player, we use this so that it wont keep running towards the player when it is right next to the player
        else if (od < safeDistance)
        {
            //looks at player
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), roationSpeed * Time.deltaTime);
                                }
	}

}
