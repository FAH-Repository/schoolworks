using UnityEngine;
using System.Collections;

public class portToBoss : MonoBehaviour {
    float portUseDis = .3f;
    public Transform player;
    public Transform tm;
    public Transform AI;
 
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(player.transform.position, AI.transform.position);

        if (distance <= portUseDis && Input.GetKeyDown(KeyCode.E))
             //   transform.Translate(Vector3.right * Time.deltaTime);
             {
            Time.timeScale = 1f;
            Time.timeScale = 0F;
            tm.transform.position = new Vector3(80, 200, 53.97577f);
        } else if (Input.GetKeyUp(KeyCode.E) &&Time.timeScale == 0) { 
            Time.timeScale = 1.0F;

            tm.transform.position = new Vector3(3000, 3000, 3000);
        }
    
        }
    }

       
       