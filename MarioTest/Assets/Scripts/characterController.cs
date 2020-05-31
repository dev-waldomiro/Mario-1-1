using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

	public float speed;
	public float jumpForce;
	private float moveInput;

	private Rigidbody2D rb;
	private SpriteRenderer sr;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        //Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput < 0)
        {
        	sr.flipX = true;
        } else if(moveInput > 0) sr.flipX = false;
    }

    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.X))
    	{
    		rb.velocity = Vector2.up * jumpForce;
    		Debug.Log(Input.GetAxis("Vertical"));
    	}
        
    }
}
