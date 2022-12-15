using UnityEngine;
using System.Collections;

public class RenemyAI : MonoBehaviour
{
    public GameObject Ptarget;
    public Transform target;
    public int moveSpeed;
    public int roationSpeed;
    public int range = 13;
    public GameObject player;
    public GameObject self;
    public int sightRange = 50;

    private Transform myTransform;

    void Awake()
    {
        myTransform = transform;

    }

    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("player");

        target = go.transform;

    }

    // Update is called once per frame
    void Update()
    {
//distance between this enemy and the player
        float distance = Vector3.Distance(Ptarget.transform.position, transform.position);
        // od is object distance, basically another distance variable
        var od = Vector3.Distance(player.transform.position, self.transform.position);

        //finds path
        Debug.DrawLine(target.position, myTransform.position, Color.yellow);

        //not close enough to shoot
        if (od < range && od < sightRange && distance > 6)
        {
            //move toward target
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

            //looks at player
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), roationSpeed * Time.deltaTime);
        }
        //attacks when player is in range and not to close
        else if (od > range && distance > 7)
        {
          
            //looks at player
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), roationSpeed * Time.deltaTime);
        }
//runs if player gets to close
        else if(distance < 7){
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), roationSpeed * Time.deltaTime);
        }
    }
}
