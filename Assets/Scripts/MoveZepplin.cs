using System;
using UnityEngine;
using System.Collections;

public class MoveZepplin : MonoBehaviour {
    public float speed = 1.0f;
    public float minY = 10f;
    public float maxY = 1.25f;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(-transform.up * 20f);
	}
	
	// Update is called once per frame
	void Update () {

	    if (transform.position.y <= maxY)
	    {
	        transform.position = new Vector3(transform.position.x, maxY, -1);
	        rb.velocity = Vector3.zero;
	    }
	    else
	    {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(transform.right);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-transform.right);
            }
	        if (Input.GetKey(KeyCode.UpArrow))
	        {
	            rb.AddForce(transform.up);
	        }
	        if (Input.GetKey(KeyCode.DownArrow))
	        {
	            rb.AddForce(-transform.up);
	        }
	    }
	}
}
