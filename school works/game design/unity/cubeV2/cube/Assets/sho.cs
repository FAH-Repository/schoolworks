using UnityEngine;
using System.Collections;

public class sho : MonoBehaviour
{


    public GameObject cam;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = cam.transform.rotation;
    }
}
