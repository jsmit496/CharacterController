using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputDebug : MonoBehaviour {

    public Transform upBox, downBox, leftBox, rightBox;

    public float motionScale = 10f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        upBox.localScale = new Vector3(1, 0.1f, 1);
        downBox.localScale = new Vector3(1, 0.1f, 1);
        leftBox.localScale = new Vector3(1, 0.1f, 1);
        rightBox.localScale = new Vector3(1, 0.1f, 1);

        if (mouseX > 0)
        {
            // Scale the right box
            rightBox.localScale = new Vector3(1, mouseX * motionScale, 1);
        }
        
        if (mouseX < 0)
        {
            // Scale the left box
            leftBox.localScale = new Vector3(1, mouseX * motionScale, 1);
        }

        if (mouseY > 0)
        {
            upBox.localScale = new Vector3(1, mouseY * motionScale, 1);
        }

        if (mouseY < 0)
        {
            downBox.localScale = new Vector3(1, mouseY * motionScale, 1);
        }

    }
}
