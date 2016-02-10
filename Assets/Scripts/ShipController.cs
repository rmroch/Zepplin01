using System;
using UnityEngine;
using System.Collections;
using System.Diagnostics;
using Random = UnityEngine.Random;

public class ShipController : MonoBehaviour {

    public float rotSpeed = .5f;
    public float speed;
    public Transform target;
    

    private float xPos = 0.0f;
    private float yPos = 0.0f;
    private float yForce = 0.1f;
    private float xForce = 0.2f;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(transform.right * Random.Range(-50f, 50f));
        //rb.AddForce(transform.up * Random.Range(-100f, 100f));
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //if (transform.position.x <= -1.8)
        //{
        //    rb.velocity = Vector2.zero;
            
        //}
        //if (transform.position.x >= 1.7)
        //{
        //    rb.velocity = Vector2.zero;
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //}

        //if (transform.position.y <= -3)
        //{
        //    rb.velocity = Vector2.zero;
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //}
        //if (transform.position.y >= 3)
        //{
        //    rb.velocity = Vector2.zero;
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //}
	}
}
