using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControls : MonoBehaviour {

    public float speed = 4.0f;
    public float motionScale = 90f;
    public float maxAngle = 90f;

    public Transform playerCamera;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 moveDirection = Vector3.zero;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Input.GetKey(KeyCode.W))
        {
            //moveDirection += new Vector3(0, 0, 1);

            moveDirection += transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += -transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += -transform.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right;
        }

        transform.position += moveDirection * speed * Time.deltaTime;

        if (mouseX > 0)
        {
            transform.Rotate(transform.up, motionScale * Time.deltaTime, Space.World);
        }

        if (mouseX < 0)
        {
            transform.Rotate(-transform.up, motionScale * Time.deltaTime, Space.World);
        }

        // Try this approach:
        // "If I am more than (max degrees) away from dead-center,
        // then return to dead-center view, and then
        // rotate (max degrees) in the appropriate direction from dead-center.

        if (mouseY > 0)
        {
            playerCamera.transform.Rotate(-transform.right, motionScale * Time.deltaTime, Space.World);

            // if (Vector3.Angle(transform.forward, playerCamera.forward) > max) 
            // {
            //      playerCamera.transform.forward = transform.forward;
            //      playerCamera.transform.Rotate(to the maximum distance.)
            // }
            if (Vector3.Angle(transform.forward, playerCamera.forward) > maxAngle)
            {
                playerCamera.transform.forward = transform.forward;
                playerCamera.transform.Rotate(-transform.right, maxAngle, Space.World);
            }
        }

        if (mouseY < 0)
        {
            playerCamera.transform.Rotate(transform.right, motionScale * Time.deltaTime, Space.World);

            if (Vector3.Angle(transform.forward, playerCamera.forward) > maxAngle)
            {
                playerCamera.transform.forward = transform.forward;
                playerCamera.transform.Rotate(transform.right, maxAngle, Space.World);
            }
        }
    }
}
