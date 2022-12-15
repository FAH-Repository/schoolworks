using UnityEngine;
using System.Collections;

public class creditScrolly : MonoBehaviour {

    // Use this for initialization
    public GameObject scrollyTexttheObject;
    public float speed;
    public float s;


    // Update is called once per frame
    void Update() {
        scrollyTexttheObject.transform.Translate(Vector3.up * Time.deltaTime * speed);

        StartCoroutine(waitFor());
    }
    IEnumerator waitFor() {
        yield return new WaitForSeconds(s);
        Application.LoadLevel(0);
    }
}