using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipOrbit : MonoBehaviour
{
    public GameObject ship;
    public float rotateSpeed;
    public float forwardSpeed;

    void Start ()
    {
		
	}
	

	void Update ()
    {
        ship.transform.Translate(-Vector3.forward * Time.deltaTime * forwardSpeed);
        ship.transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
