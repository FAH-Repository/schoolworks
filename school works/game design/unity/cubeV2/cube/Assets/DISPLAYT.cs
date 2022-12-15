using UnityEngine;
using System.Collections;

public class DISPLAYT : MonoBehaviour
{
    float UseDis = 10f;
    public GameObject villager;
    public GameObject player;
    public Renderer rend;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(villager.transform.position, player.transform.position);
     
        if (distance <= UseDis)
        {
            rend.enabled = true;
        }
        else {
            rend.enabled = false;

 }

    }
}
