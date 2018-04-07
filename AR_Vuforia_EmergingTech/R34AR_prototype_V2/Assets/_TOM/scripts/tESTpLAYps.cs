using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tESTpLAYps : MonoBehaviour
{
    public GameObject marker;
    ParticleSystem PS;


	// Use this for initialization
	void Start ()
    {
        PS = marker.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        PS.Play();
	}
}
