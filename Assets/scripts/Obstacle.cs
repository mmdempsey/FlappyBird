using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	
	// Movement speed
	public float speed = 0;
	
	// Switch Movement Direction every x seconds
	public float switchTime = 2;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
		
		// Switch every few seconds
		InvokeRepeating("Switch", 0,  switchTime);
	}
	
	void Switch() {
		GetComponent<Rigidbody2D>().velocity *= -1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
