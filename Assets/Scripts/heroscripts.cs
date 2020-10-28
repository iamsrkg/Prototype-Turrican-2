using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroscripts : MonoBehaviour
{
    public Vector3 facing = Vector3.right;
    [SerializeField] private float speed = 10f;

    public float jumpSpeed = 8f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Turn(horizontal);
        transform.Translate(horizontal * speed * Time.deltaTime, 0f, 0f);
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }

    }

    private void Turn(float horizontal)
    {
        if(facing == Vector3.right && horizontal < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            facing = Vector3.left;
        }
        else if(facing == Vector3.left && horizontal > 0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            facing = Vector3.right;
        }
    }
}
