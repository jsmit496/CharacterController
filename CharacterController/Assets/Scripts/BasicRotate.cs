using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRotate : MonoBehaviour {

    public float rotationSpeed = 360f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        //transfrom.Rotate(transform.up, rotationSpeed * Time.deltaTime, Space.World);
	}
}
