using UnityEngine;
using System.Collections;

public class GuiScreen : MonoBehaviour {
    float portUseDis = .3f;
    public Transform player;
    
    public Transform TR;
    public Transform tr;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float distance = Vector3.Distance(player.transform.position, TR.transform.position);

        if (distance <= portUseDis && Input.GetKeyDown(KeyCode.E))
             //   transform.Translate(Vector3.right * Time.deltaTime);
             {
            Time.timeScale = 1f;
            Time.timeScale = 0F;
            tr.transform.position = new Vector3(80, 200, 50f);
        } else if (Input.GetKeyUp(KeyCode.E) && Time.timeScale == 0) {
            Time.timeScale = 1.0F;

            tr.transform.position = new Vector3(3000, 3000, 3000);
        }

    }
}


