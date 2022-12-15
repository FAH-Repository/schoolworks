using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {


    public Transform Ps;

    void OnMouseUp() {
        //is this quit

        //if (Pause == true) {

          //  GameObject.setActive(true);
            //   Application.LoadLevel(3);

       // }
    }
    void Update() {
        transform.Translate(Vector3.right * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (Time.timeScale == 1.0F) {
                Time.timeScale = 0F;
                Ps.transform.position = new Vector3(75, 165, 53.97577f);
            } else {
                Time.timeScale = 1.0F;
             
                Ps.transform.position = new Vector3(1000, 1000, 1000);
            }
          //  Time.fixedDeltaTime = 0.02F * Time.timeScale;
            // if (Input.GetKeyDown(KeyCode.Escape)) {
            //  Transform P = Ps.FindChild("P");
            //   P.GetComponent<Canvas>().enabled = true;
            //  Time.timeScale = 0;
            //    P.setActive(true);
            //    Debug.Log("Pause");
            //   } else {
            //     Time.timeScale = 1;
        }
   }
}