using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary> Starts up the Player </summary>
public class PlayerController : MonoBehaviour
{
	public int score = 0;
	public int health = 5;
	public float speed = 5.0F;

	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	///<summary> WASD or Arrow Keys uesed </summary>
	void FixedUpdate()
	{
		if ( Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if ( Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
	} 
}