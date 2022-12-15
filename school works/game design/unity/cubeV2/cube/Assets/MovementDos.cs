using UnityEngine;
using System.Collections;

public class MovementDos : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    bool isDead = false;
    bool flapTrigger;
    Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveSpeed, 0);
     
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isDead == true)
        {
            gameObject.SetActive(false);
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            flapTrigger = true;
        }
	}

    void FixedUpdate()
    {
        if (flapTrigger)
        {
            flapTrigger = false;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0, jumpForce));


        }

    }
    void OnColide(Collision other)
    {
        isDead = true;
    }

}
