using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour
{
  
    public float moveSpeed;
    //public float roationSpeed;
    public float safeDistance = .3f;
    public Vector3 Player;
    public Vector2 playerDir;
    public int sightRange = 1;
    private float xdif;
    private float zdif;
    public Transform self;
   
    public Transform target;
   
    public int roationSpeed;
   
    public GameObject player;
   
    

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
        // od is object distance
        var od = Vector3.Distance(player.transform.position, self.transform.position);
        if (od > safeDistance && od < sightRange)
        {
            sightRange = 2;
            transform.position += (player.transform.position - transform.position).normalized * moveSpeed * Time.deltaTime;
        }

       
    }
}