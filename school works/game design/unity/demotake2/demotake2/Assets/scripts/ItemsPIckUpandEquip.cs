using UnityEngine;
using System.Collections;


public class ItemsPIckUpandEquip : MonoBehaviour {
    public int potionNum;
    public GameObject potion;
    public GameObject player2;
    public float distance; 
   
    // Use this for initialization
    void Start () {
     
    potionNum = 0; 

	
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(potion.transform.position, transform.position);
        if (distance < 1f && Input.GetKeyDown(KeyCode.E))
        {
            potionNum += 1;
            Destroy(potion); 
        }
        if (potionNum > 0)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                potionNum -= 1;
                if (Input.GetKeyDown(KeyCode.L))
                {

               
                }

            }
        }
	}
}
