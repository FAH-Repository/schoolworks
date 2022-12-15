using UnityEngine;
using System.Collections;


public class FireballRocket : MonoBehaviour
{
    public Rigidbody fireBall;
    public float speed = 10f;
    public int mouseButtonId = 0;
    public GameObject spawn;
    void FireRocket()
    {
        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection = shootDirection - transform.position;
        Rigidbody bulletInstance = Instantiate(fireBall, spawn.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody;
        bulletInstance.velocity = new Vector2(shootDirection.x * speed, shootDirection.y * speed);

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(mouseButtonId))
        {
            FireRocket();
        }
    }
}

