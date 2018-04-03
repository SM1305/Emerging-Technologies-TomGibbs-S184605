using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    public Rigidbody propeller;
    public float speed;
    public bool isSpinning = false;


	void Start ()
    {
        propeller = GetComponent<Rigidbody>();
	}
	


	void Update ()
    {
        if (isSpinning)
        {
            //propeller.transform.rotation 
        }
		
	}
}
