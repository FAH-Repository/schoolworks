using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
    public float speed = 0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            moveDirection = new Vector3(1, 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
/*
public int jumpForce;
Rigidbody rb;
public bool canJump;
// Use this for initialization
void Start () {
    rb = GetComponent<Rigidbody>();
    //canJump = true;
}

// Update is called once per frame
void Update () {
    if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
    {
      rb.velocity += new Vector3(0, jumpForce);

        canJump = false;
    }
}
void OnCollisionEnter(Collision col)
{

    if (col.gameObject.tag == "terrian")
    {
        canJump = true;
    }
}
}
*/

