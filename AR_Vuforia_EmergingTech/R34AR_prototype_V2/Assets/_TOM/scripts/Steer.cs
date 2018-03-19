using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Steer : MonoBehaviour
{
    public float rotateSpeed;
    float rotationX;
    public Rigidbody ship;

    bool rotateRight;


	void Start ()
    {
        ship = GetComponent<Rigidbody>();
        rotateRight = true;
	}
	

	void Update ()
    {
        rotationX = CrossPlatformInputManager.GetAxis("Horizontal");
        if (rotationX < 0)
            rotateRight = false;
        if (rotationX > 0)
            rotateRight = true;

        if (rotateRight)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        else if (!rotateRight)
        {
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
