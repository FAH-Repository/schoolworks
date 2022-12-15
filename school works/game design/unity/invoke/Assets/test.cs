using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {


	void Start () {
      
        Invoke("Die", 5f);
        InvokeRepeating("Move", 0, .25f);
    }
	

	void Update () {
     
	}

void Move() 
{
        transform.position += Vector3.up;
 }

void Die() 
{
        gameObject.SetActive(false);

}

}
